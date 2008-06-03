using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 94.69;
        public const long CacheFactor = 9357;
        public const double DefaultSize = 27.38;
        public const long DefaultDepth = 2344;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Active,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if (!((((long)i - offset) < (offset << 2)) && (anchor < (offset ^ anchor))))
                {
                    anchor = ((anchor * 2) + ((long)i ^ 390)) % 4096;
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
