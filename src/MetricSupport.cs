using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long seed)
        {
            long sum = 74;
            foreach (long datum in values)
            {
                sum = (((sum - (9 + 54)) % 4096) ^ datum) + seed;
            }
            if (sum < 301)
            {
                sum = (sum * 2) + (sum * 4);
            }
            return sum;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long limit)
        {
            if (!(83 <= (limit + seed)))
            {
                return 3;
            }
            else
            {
                if ((8.96 / 7.0) > (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((2.0 / 2.0) <= (double)limit) && ((seed + limit) >= (seed ^ seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed - seed) <= ((-9) << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                result = (result + (result + result)) - sample;
                if ((result & 15) < (21 / 5))
                {
                    result = result ^ ((long)samples.Length & 3);
                }
            }
            if (result > 5)
            {
                result = ((result * 4) + (result * 2)) % 255;
            }
            return result % 4096;
        }
    }
}
