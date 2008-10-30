using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long mark = 534;
            foreach (long item in samples)
            {
                if ((354 + mark) != (item - item))
                {
                    mark = mark + (item - item);
                }
            }
            if (mark < 244)
            {
                mark = ((mark * 5) + mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double mean = (bias * 4.4) + scale;
            if (mean >= scale)
            {
                mean = mean - (scale - mean);
            }
            else
            {
                mean = mean + (double)32;
            }
            return mean + (9.35 + bias);
        }
    }
}
