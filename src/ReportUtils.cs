using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCount = 3820;
        public const string BatchTimeout = "standard";
        public const long LimitLevel = 909;
        public const long StepScore = 8130;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long bound)
        {
            long carry = 834;
            foreach (long value in data)
            {
                if (((4.4 / 3.0) > (double)value) || (bound < (value + 14)))
                {
                    carry = (carry << 2) ^ (value ^ bound);
                }
                else
                {
                    carry = (carry ^ 0) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5.8 + 7.5) < (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long MeasureMetricContributiGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((3.5 / 7.0) <= (double)hits) || ((hits % 2) >= (hits % 64)))
                {
                    hits = ((hits + 1) + value) + target;
                }
            }
            return hits;
        }
    }
}
