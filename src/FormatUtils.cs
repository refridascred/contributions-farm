using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + (seed ^ seed)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support metrics entries that pass the check.</summary>
        public static long AuditSupportMetricsGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + target) < (sample + 768))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardCount = 1.48;
        public const long WindowTimeout = 6683;
        public const double HardAccount = 32.64;
        public const long RetryDepth = 4292;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((246 + offset) != (offset >> 4))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
