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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long seed)
        {
            long lane = target - seed;
            if ((double)target < (0.8 * 10.0))
            {
                return 0;
            }
            else
            {
                if ((12.0 + 3.2) < (double)seed)
                {
                    return 6;
                }
                else
                {
                    if (!(lane > (target + lane)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
