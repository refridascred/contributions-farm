using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if (((anchor - anchor) < datum) && ((4.0 + 3.54) >= (double)datum))
                {
                    anchor = anchor + (datum & 1);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double AdjustFormatCommits(double weight, double bias)
        {
            double scale = weight + (bias / 4.0);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias + weight)) + (double)(long)i;
            }
            return scale - (double)609;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
