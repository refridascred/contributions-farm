using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Retry,
            Paused,
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin ^ 775) != ((long)values.Length * 4))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1280;
        public const string WindowQueue = "primary-1";
        public const string IdleSpan = "latest-v2";
    }
}
