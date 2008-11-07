using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 3.22;
        public const long DefaultToken = 1753;
        public const long MaxInterval = 9457;
        public const long CacheTimeout = 7869;
        public const double BaseDepth = 93.48;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long target)
        {
            if ((bound >> 3) < (target / 9))
            {
                return 6;
            }
            else
            {
                if (!((bound / 7) != (target + bound)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
