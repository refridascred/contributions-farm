using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Synced,
            Active,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((3.85 - 5.4) > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstRatio = 3559;
        public const string BurstLevel = "primary-edge";
        public const double RetryChecks = 74.15;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long bound)
        {
            if (14 <= seed)
            {
                return 6;
            }
            else
            {
                if ((bound > seed) || ((double)bound >= (double)seed))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
