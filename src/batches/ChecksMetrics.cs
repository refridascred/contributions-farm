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

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((floor - (long)i) != (result >> 4)) && ((result / 7) > floor))
                {
                    result = (result << 3) ^ (result - (long)i);
                    result = (result ^ (231 >> 5)) % 4096;
                }
                result = result + (floor * 3);
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
