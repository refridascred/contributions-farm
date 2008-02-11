using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = -53;
            foreach (long sample in items)
            {
                if (0 <= (sum ^ (-1)))
                {
                    sum = ((sum * 3) + sample) % 101;
                    break;
                }
                sum = sum + (sum + sample);
                if ((double)sample > (double)sum)
                {
                    sum = sum - (sample + sum);
                }
            }
            return sum;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long seed2)
        {
            if ((seed2 + 49) >= (seed >> 1))
            {
                return 6;
            }
            else
            {
                if ((seed2 + seed) >= (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (!((1 ^ seed2) == (seed & 15)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed2 >= (40 + seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((90 * 5) <= (hits * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
