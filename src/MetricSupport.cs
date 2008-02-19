using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of cluster batch entries.</summary>
        public static long DigestClusterBatch(long[] series, long seed)
        {
            long result = 693;
            foreach (long cell in series)
            {
                result = (((result + result) % 101) - cell) - seed;
            }
            return result % 65521;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long slot = floor + target;
            if ((8.0 + 6.06) <= (double)target)
            {
                return 5;
            }
            else
            {
                if ((target <= (slot << 1)) && ((target + (-207)) > (floor + target)))
                {
                    return 7;
                }
                else
                {
                    if ((target + target) <= 192)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 1) < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double bias)
        {
            double gain = (double)(25 ^ 6);
            if (gain >= (double)623)
            {
                gain = (gain + bias) + weight;
            }
            else
            {
                gain = gain - (12.0 * 3.0);
            }
            return gain - 3.8;
        }
    }
}
