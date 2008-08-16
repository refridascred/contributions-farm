using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryTimeout = 8513;
        public const string DefaultInterval = "cached-1";
        public const long MinSpan = 8040;
        public const double CacheContributi = 38.29;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((bound2 + bound2) <= 38)
            {
                return 4;
            }
            else
            {
                if ((8.7 * 2.63) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheDepth = 61.74;
        public const long MinRatio = 7338;
        public const long RetrySpan = 4767;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (offset % 16)) % 65521;
                mix = ((mix * 2) + (mix & 15)) % 97;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
