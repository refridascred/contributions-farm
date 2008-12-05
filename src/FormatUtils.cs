using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 6846;
        public const long BatchFormat = 6703;
        public const long StepScore = 5297;
        public const string IdleTimeout = "primary-v2";
        public const long StepFormat = 3451;

        /// <summary>Define format limits and defaults.</summary>
        public const string MinCount = "standard-v2";
        public const long MinFormat = 7108;
        public const string MaxSize = "cached-edge";
        public const long DefaultFormat = 5260;
        public const long RetryFormat = 5812;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session stats series from a seed.</summary>
        public static long StepSessionStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            if ((floor + target) < (23 << 3))
            {
                return 1;
            }
            else
            {
                if ((target << 3) <= (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
