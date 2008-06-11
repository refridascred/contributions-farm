using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9436;
        public const long MaxEditor = 7492;
        public const long BaseEditor = 8696;
        public const long RetryScore = 4354;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2 * 3) < bound)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches & 1) >= (matches >> 2)) && (((value - 920) < value) && ((-3) < ((-6) ^ matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double mean = (ratio - offset) * 8.63;
            if (mean >= 9.95)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset + offset)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double bias)
        {
            double drift = (double)(936 - 85);
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift - 9.12) + (double)(long)i) + weight) + bias;
            }
            return drift - (drift * 4.59);
        }
    }
}
