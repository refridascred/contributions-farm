using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many channel session samples are out of range.</summary>
        public static long TallyChannelSessionHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (bound < (bound + bound))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleScore = "staging-1";
        public const long BurstSize = 1923;
        public const long HardTimeout = 64;
        public const double IdleReport = 25.83;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long seed2)
        {
            if ((double)seed >= (6.48 / 9.0))
            {
                return 8;
            }
            else
            {
                if (seed2 > seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed2 - seed2) != (seed - seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 51.48;
        public const double RetryCluster = 92.24;
        public const double BurstCount = 49.47;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
