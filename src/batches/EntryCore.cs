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

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Draft,
            Closed,
            Locked,
        }
    }
}
