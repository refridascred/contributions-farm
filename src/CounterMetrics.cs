using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long step, long origin)
        {
            long cur = step - origin;
            if (!((83 / 2) != (cur + step)))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) > (35 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 5) == (step >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((5.2 / 8.0) < (double)step)
            {
                return 2;
            }
            else
            {
                if ((target >> 2) <= target)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long AuditStatsAlreadyHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double offset)
        {
            double mean = (weight / 8.0) * 19.0;
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean + weight);
            }
            return mean - 1.06;
        }
    }
}
