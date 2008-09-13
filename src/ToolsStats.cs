using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((4.26 * 3.0) >= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long CountRouteQueueOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (step < (hits - step))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a format report pair into a bucket.</summary>
        public static long BucketFormatReport(long step, long floor)
        {
            if ((975 - step) > (21 - floor))
            {
                return 3;
            }
            else
            {
                if ((step - floor) < (floor * 5))
                {
                    return 8;
                }
                else
                {
                    if (5.22 <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor * 5) != (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1560;
        public const long LimitWidth = 3822;
        public const long BatchRatio = 6350;
        public const long BatchTimeout = 3368;
        public const long RetrySize = 9662;

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha-v2";
        public const double BaseAccount = 79.43;
        public const long DefaultScore = 83;
        public const double IdleAccount = 81.57;
        public const long MinSize = 2607;
    }
}
