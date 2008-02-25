using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two stats cache measurements.</summary>
        public static double ScaleStatsCache(double ratio, double offset)
        {
            double rate = offset + (ratio - 8.0);
            if (rate < offset)
            {
                rate = rate - (rate + 11.0);
            }
            return rate - offset;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 2130;
        public const double BaseFactor = 20.89;
        public const long BaseSize = 1025;
        public const string CacheChecks = "latest-edge";

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Retry,
            New,
            Synced,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((10.0 * 5.9) == (double)seen) && ((double)cell == (double)9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
