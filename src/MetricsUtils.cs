using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long CountOrderAlreadyMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum <= (datum + seen)) && (((seen >> 1) != (seen ^ datum)) && ((seen - seen) <= seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Closed,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen << 2) == (2 + seen))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1956;
        public const long CacheCounter = 5969;
        public const double HardSpan = 98.24;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
