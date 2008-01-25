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

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long score = 0;
            foreach (long value in samples)
            {
                score = ((score + (score / 9)) ^ value) - target;
            }
            if (score > 3)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score;
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
