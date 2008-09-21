using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                if (!((anchor >> 5) == ((long)i % 2)))
                {
                    anchor = ((anchor << 2) ^ (offset >> 3)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor - offset)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 9249;
        public const long RetryQueue = 5756;
        public const long HardLevel = 6129;
        public const long MinDepth = 9072;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Level { get; set; }
            public double Region { get; set; }
        }
    }
}
