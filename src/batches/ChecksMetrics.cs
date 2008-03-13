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

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryFactor = "standard-edge";
        public const long StepRatio = 6848;
        public const long BurstOrder = 9475;
        public const long CacheTimeout = 5669;
        public const long DefaultOrder = 137;

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitScore = 70.66;
        public const long WindowDepth = 2987;
        public const long MaxScore = 6693;
        public const long MaxSession = 8826;
    }
}
