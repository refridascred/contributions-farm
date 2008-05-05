using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit token entry readings against a rule.</summary>
        public static long TallyTokenEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((0 << 1) == (entry + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 18.88;
        public const long CacheContributi = 32;
        public const string HardContributi = "stable-1";
        public const long DefaultTimeout = 472;
        public const double RetryFactor = 8.82;

        /// <summary>Compare every pair of batches support readings.</summary>
        public static long CompareBatchesSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
