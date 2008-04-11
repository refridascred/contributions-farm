using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (((limit - limit) <= (bound ^ limit)) || ((limit / 3) > (offset + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.8 - 2.6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "cached-edge";
        public const long CacheDepth = 4302;
        public const long MinLayout = 5831;
        public const string CacheCount = "stable-v2";
        public const long BurstLayout = 2798;
    }
}
