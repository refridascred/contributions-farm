using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Failed,
            Paused,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((seed + seed) <= seed)
            {
                return 3;
            }
            else
            {
                if (((seed + 41) < lane) || ((seed - bound) != ((-3) ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 7) == (68 >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double bias = 3.1 / 5.0;
            if (bias > (3.58 - scale))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + scale;
            }
            return bias - (span + bias);
        }
    }
}
