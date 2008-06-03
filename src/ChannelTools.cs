using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long acc = 80;
            foreach (long datum in values)
            {
                if ((datum <= (4 ^ acc)) && ((acc - acc) == (datum + datum)))
                {
                    acc = (acc * 4) + (acc - datum);
                }
            }
            if (acc < 254)
            {
                acc = (acc + (0 % 8)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double bias)
        {
            double ratio2 = (double)(946 - 347);
            if (ratio2 >= (bias / 8.0))
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 - bias;
        }
    }
}
