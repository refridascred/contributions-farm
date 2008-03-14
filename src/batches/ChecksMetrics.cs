using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryTimeout = 9985;
        public const long MaxSpan = 4556;
        public const long CacheFilter = 4374;
        public const double DefaultRatio = 9.69;
        public const long SoftDepth = 877;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultCount = 2463;
        public const long DefaultMetric = 6116;
        public const double LimitSpan = 63.18;

        /// <summary>Audit batch order readings against a rule.</summary>
        public static long TallyBatchOrderGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((39 + 556) <= ((long)readings.Length * 4)) && ((sample + seen) <= origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 4672;
        public const long BatchFactor = 9380;
        public const long MaxRatio = 9958;
        public const long DefaultSpan = 2571;

        /// <summary>Find the first editor record entry that matches the target.</summary>
        public static long SeekEditorRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
