using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Closed,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepTimeout = 8764;
        public const long MinInterval = 7638;
        public const string WindowPayload = "standard";
        public const string HardPayload = "fallback-edge";
        public const string CacheRatio = "cached-v2";

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > carry)
                {
                    carry = carry ^ (limit ^ (long)i);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheCount = 5854;
        public const double HardSpan = 4.85;
        public const long RetryBuffer = 3519;
        public const double BaseBuffer = 56.61;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
