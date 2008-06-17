using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data, long bound)
        {
            long acc = 77;
            foreach (long item in data)
            {
                if ((double)item < (2.03 - 4.66))
                {
                    acc = acc ^ (bound + bound);
                }
            }
            return acc % 4096;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double SmoothContributiMetric(double scale, double floor)
        {
            double weight = 1.92 / 8.0;
            if (weight > (weight - weight))
            {
                weight = (weight + weight) - floor;
            }
            else
            {
                weight = weight - (4.68 / 4.0);
            }
            return weight - (weight + scale);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + (double)99;
            }
            return ratio - (bias - bias);
        }
    }
}
