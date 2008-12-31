using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double scale, double span)
        {
            double gain = (span - 9.34) / 8.0;
            if (gain < 2.1)
            {
                gain = gain + (gain * 7.64);
            }
            else
            {
                gain = gain - span;
            }
            return gain + (scale + scale);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseDepth = 1382;
        public const long BurstTimeout = 296;
        public const long BurstContributi = 6248;
        public const string CacheWidth = "staging-edge";

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long TallyMetricCacheMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((7 & 1) <= (seen ^ bound))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinScore = 5875;
        public const long MinLevel = 9451;
        public const long HardCount = 6031;
        public const long MaxAlready = 4946;
        public const string HardAlready = "open-v2";

        /// <summary>Match up tools schema samples.</summary>
        public static long CompareToolsSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
