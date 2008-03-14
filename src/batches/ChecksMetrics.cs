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

        /// <summary>Adjust a session order reading.</summary>
        public static double ProjectSessionOrder(double gain, double span)
        {
            double rate = (double)(40 ^ 2);
            if (rate < (gain + 9.0))
            {
                rate = (rate + rate) + span;
            }
            return rate - (3.52 * 7.1);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
