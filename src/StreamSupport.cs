using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 9739;
        public const string LimitSpan = "staging";
        public const double BatchDepth = 43.13;
        public const long RetryRatio = 383;

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((0.15 + 7.5) != (double)seen) || ((reading + seen) >= (seen * 3)))
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

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Stale,
            Dropped,
            Locked,
        }
    }
}
