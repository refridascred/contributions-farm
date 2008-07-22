using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinContributi = "staging";
        public const long MaxContributi = 592;
        public const double DefaultContributi = 29.26;
        public const double BurstBudget = 28.54;

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCount = 45.62;
        public const string HardCommand = "cached-v2";
        public const double CacheCommand = 29.93;
        public const string BurstDepth = "latest-v2";

        /// <summary>Compare every pair of already format readings.</summary>
        public static long MatchAlreadyFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (1.36 >= (double)hits)
                {
                    hits = ((hits + 2) ^ entry) - step;
                }
            }
            return hits;
        }
    }
}
