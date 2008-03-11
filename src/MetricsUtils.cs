using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long floor)
        {
            if ((offset ^ offset) > (offset & 255))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (3.0 - 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((7 ^ offset) > (offset + offset))
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

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double gain = bias * 7.04;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 2.93) + (double)(long)i;
            }
            return gain + (rate * 9.5);
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long bound)
        {
            if (limit <= (47 << 2))
            {
                return 3;
            }
            else
            {
                if (bound > limit)
                {
                    return 4;
                }
                else
                {
                    if (((642 - bound) > (bound >> 4)) && ((5 + 235) > (6 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound + limit) > (limit & 127)) || (limit >= (13 * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
