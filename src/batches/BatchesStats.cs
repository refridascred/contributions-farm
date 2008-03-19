using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if (((double)mix != (8.59 / 5.0)) || ((item % 3) == (mix + mix)))
                {
                    mix = (mix + (mix << 1)) % 65521;
                    continue;
                }
                if ((item - item) >= mix)
                {
                    mix = ((mix * 2) + (mix + item)) % 4096;
                }
            }
            if (mix > 343)
            {
                mix = ((mix * 5) + (mix / 8)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double bias2 = scale;
            return (bias2 - scale) + bias;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 3.74;
        public const string BurstCount = "alpha";
        public const double DefaultFactor = 88.66;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
