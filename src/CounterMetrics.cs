using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double floor)
        {
            double load = (double)670 * 9.41;
            return (load - (load + gain)) + floor;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long SeriesLayoutOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry - 75) % 65521;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long floor)
        {
            if ((((-597) - floor) < (limit / 2)) || ((74 / 9) >= (limit << 3)))
            {
                return 6;
            }
            else
            {
                if (!((floor * 5) != (5 * 3)))
                {
                    return 1;
                }
                else
                {
                    if (!((49 + 84) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor % 100) > 4)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
