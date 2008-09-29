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

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels, long step)
        {
            long result = 443;
            foreach (long sample in levels)
            {
                if ((double)sample != (double)result)
                {
                    result = ((result - (result + result)) % 4096) - step;
                }
            }
            if (result < 892)
            {
                result = (result ^ (95 >> 5)) % 4096;
            }
            return result;
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
