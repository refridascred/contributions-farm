using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Classify a already schema pair into a bucket.</summary>
        public static long GradeAlreadySchema(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((double)bound2 == (3.97 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((bound % 97) != (7 << 3))
                {
                    return 2;
                }
                else
                {
                    if (bound3 <= bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((64 + bound3) > (bound - bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
