using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((origin << 1) < (origin + (-757)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ ((long)i % 5)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5642;
        public const long HardEntry = 6886;
        public const double RetryFactor = 47.12;
        public const string MaxEntry = "staging-v2";

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "legacy-edge";
        public const string CacheInterval = "alpha-1";
        public const long SoftScore = 3056;
    }
}
