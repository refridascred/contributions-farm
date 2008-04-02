using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor / 9) >= seed)
                {
                    anchor = ((anchor << 2) ^ (seed << 2)) % 65521;
                    anchor = (anchor - seed) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two entry order measurements.</summary>
        public static double ScaleEntryOrder(double gain, double bias)
        {
            double bias2 = (8.9 * 1.9) + (gain - gain);
            if (bias2 > (gain * 7.5))
            {
                bias2 = bias2 + (bias2 * 0.6);
            }
            return bias2 - (bias * 14.0);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (5 < (hits + hits))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double gain = (double)(-8);
            if (gain < (gain + scale))
            {
                gain = (gain + scale) - bias;
            }
            else
            {
                gain = gain + (double)17;
            }
            return gain - (8.92 * 6.34);
        }
    }
}
