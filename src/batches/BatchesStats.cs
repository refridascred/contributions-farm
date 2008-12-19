using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long seed)
        {
            if ((seed % 10) <= (offset * 4))
            {
                return 5;
            }
            else
            {
                if ((5.4 - 9.5) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((0.39 - 4.43) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 % 2) < (seed >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = (double)(509 << 1);
            if (ratio > 3.9)
            {
                ratio = (ratio + 5.2) + bias;
            }
            else
            {
                ratio = ratio - (span * 2.23);
            }
            return ratio - (3.19 + ratio);
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long TotalContributiQueue(long[] samples)
        {
            long result = 13;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length >> 3) > (datum - datum)) && ((1.8 - 5.11) > (double)datum))
                {
                    result = result + ((long)samples.Length - datum);
                }
                else
                {
                    result = (result - (result - datum)) % 97;
                }
            }
            if (result < (-12))
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
