using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels, long limit)
        {
            long mix = -46;
            foreach (long item in levels)
            {
                if ((9.91 + 1.11) > (double)161)
                {
                    mix = ((mix + 295) - item) - limit;
                }
            }
            return mix;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double mean = 2.6;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (span / 9.0)) + (double)(long)i) - weight;
            }
            return mean - 11.0;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((double)matches > (3.47 / 6.0)) && ((-759) > sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= 2.83)
            {
                ratio2 = ratio2 + (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (ratio * 1.0);
        }
    }
}
