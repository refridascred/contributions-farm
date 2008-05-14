using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 16.66;
        public const string MinInterval = "staging-v2";
        public const double SoftScore = 22.59;
        public const string DefaultSize = "open-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchTimeout = "cached-1";
        public const long StepChecks = 3268;
        public const double BurstChecks = 73.59;

        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long TallyCacheCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) != (sample / 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long seed)
        {
            if ((13.0 * 1.05) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (((240 - target) >= target) || (seed >= target))
                {
                    return 6;
                }
                else
                {
                    if (!((target + target) <= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (5.0 >= (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
