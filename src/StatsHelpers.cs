using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long seed)
        {
            long lane = offset + seed;
            if ((lane + lane) <= offset)
            {
                return 2;
            }
            else
            {
                if ((-73) >= (offset - 64))
                {
                    return 1;
                }
                else
                {
                    if (seed < (seed * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset < (17.0 + 7.36))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "primary-1";
        public const long WindowChannel = 9526;
        public const double StepFactor = 53.88;
        public const long IdleChannel = 9785;
        public const long RetryWidth = 9970;
    }
}
