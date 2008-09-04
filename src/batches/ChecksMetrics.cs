using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 9524;
        public const long CacheLevel = 1474;
        public const double DefaultRatio = 29.43;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 23.48;
        public const string HardSize = "legacy-edge";
        public const long MaxBuffer = 2037;
        public const long BatchBuffer = 5255;
        public const string LimitSize = "primary-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinFactor = 4742;
        public const long HardSchema = 7906;
        public const long DefaultSize = 2550;
        public const string StepSchema = "alpha";

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count / 4) <= (995 + sample)) || ((96 - (long)series.Length) > count)) && ((sample + sample) >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
