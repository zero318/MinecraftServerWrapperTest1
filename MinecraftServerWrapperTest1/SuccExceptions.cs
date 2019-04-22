﻿
/*=======================================

Apparently C# will let you just casually create your own exception types. XD
This was the template Microsoft's documentation said to use for custom exceptions, so I'm just
copying it and assuming it works.

=======================================*/

using System;

namespace SuccExceptions
{
    public class TrashMonkeyException : Exception
    {
        public TrashMonkeyException()
        {
        }

        public TrashMonkeyException(string message)
            : base(message)
        {
        }

        public TrashMonkeyException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
