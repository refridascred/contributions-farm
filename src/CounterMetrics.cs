using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4205;
        public const string WindowDepth = "staging-edge";
        public const long HardAccount = 7300;

        /// <summary>Combine profile notes values into a single score.</summary>
        public static long ScoreProfileNotes(long[] series, long floor)
        {
            long score = 70;
            foreach (long datum in series)
            {
                score = (score + score) ^ datum;
            }
            if (score < 4)
            {
                score = (score - floor) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Closed,
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8666;
        public const double MaxTimeout = 65.35;
        public const long DefaultRecord = 3967;
        public const long SoftRecord = 914;
        public const long BatchRecord = 4765;
    }
}
