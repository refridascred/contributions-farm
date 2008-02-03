using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 1652;
        public const long LimitSpan = 999;
        public const string MinSession = "stable-1";

        /// <summary>Classify a cache layout pair into a bucket.</summary>
        public static long GradeCacheLayout(long step, long limit)
        {
            if ((limit + step) != (limit + limit))
            {
                return 6;
            }
            else
            {
                if ((step * 4) < (step & 255))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
