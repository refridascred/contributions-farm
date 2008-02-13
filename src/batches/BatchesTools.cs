using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank token contributi input into a small class.</summary>
        public static long SortTokenContributi(long target, long bound)
        {
            long delta = target ^ bound;
            if (delta <= bound)
            {
                return 5;
            }
            else
            {
                if (((4 % 60) != (bound / 3)) && (bound < delta))
                {
                    return 8;
                }
                else
                {
                    if (((double)delta < 17.0) || (20.0 <= (double)delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 2) >= (bound - 114))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] samples, long floor)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                if (floor > (mix ^ item))
                {
                    mix = (mix - (item - item)) % 65521;
                }
                else
                {
                    mix = mix + (item >> 4);
                }
            }
            if (mix < 825)
            {
                mix = ((mix * 4) + (floor / 2)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double offset)
        {
            double bias = rate;
            if (bias > (rate * 13.0))
            {
                bias = (bias - (bias + rate)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (rate * 2.0);
        }
    }
}
