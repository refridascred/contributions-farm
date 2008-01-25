using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((((-411) * 2) != (sample - sample)) && ((7.0 * 7.5) > (double)sample)) && (sample >= (169 + 109)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Paused,
            Retry,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Fold a list of commits layout readings.</summary>
        public static long FoldCommitsLayout(long[] values, long step)
        {
            long sum = 2;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ (step ^ sum)) - reading;
            }
            if (sum < 622)
            {
                sum = ((sum << 3) ^ (step + step)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
