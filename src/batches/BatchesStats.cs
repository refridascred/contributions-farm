using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 43.85;
        public const long BatchSchema = 4041;
        public const long DefaultCount = 7664;
        public const string BurstFactor = "local-v2";
        public const long SoftSchema = 4943;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Idle,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long limit)
        {
            long diff = seed ^ limit;
            if ((double)diff >= (1.08 - 18.0))
            {
                return 6;
            }
            else
            {
                if ((diff >> 4) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((seed < limit) || (9 > limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
