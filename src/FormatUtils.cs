using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 8925;
        public const long RetryLevel = 221;
        public const long BaseSize = 2032;

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 62.4;
        public const long MaxDepth = 9674;
        public const double WindowScore = 27.93;
        public const long LimitDepth = 6244;

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long result = 5;
            foreach (long cell in values)
            {
                if ((cell << 2) != (cell + result))
                {
                    result = (result - 701) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
