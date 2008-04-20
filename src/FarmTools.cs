using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values)
        {
            long mark = 44;
            foreach (long cell in values)
            {
                if (9.8 > (double)(long)values.Length)
                {
                    mark = (mark * 5) + (long)values.Length;
                }
                else
                {
                    mark = mark ^ (784 + cell);
                }
            }
            if (mark < (-193))
            {
                mark = (mark + (15 - mark)) % 101;
            }
            return mark;
        }
    }
}
