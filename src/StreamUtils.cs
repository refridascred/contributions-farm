using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample % 60) != (seen - sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 6462;
        public const long SoftNotes = 1975;
        public const double MaxNotes = 34.41;
        public const long MaxBudget = 1313;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstBudget = 34.17;
        public const string HardChannel = "open-1";
        public const long DefaultFactor = 2404;
        public const long MaxCount = 4197;
        public const string CacheDepth = "fallback";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((((seed * 2) < seed) || ((value + seen) != (value + value))) && ((double)seed <= (9.8 * 5.7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
