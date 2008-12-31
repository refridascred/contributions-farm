using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultSize = 81.44;
        public const long SoftCounter = 1738;
        public const double WindowBudget = 79.82;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long total = 985;
            foreach (long sample in samples)
            {
                total = (total << 3) ^ (-254);
                total = total + (sample + sample);
                if (15.0 >= (double)total)
                {
                    total = ((total << 2) ^ (total ^ 39)) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ total) % 97;
                }
            }
            return total % 65521;
        }

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
