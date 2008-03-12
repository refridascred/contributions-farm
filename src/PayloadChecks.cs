using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches == (double)reading)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Retry,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSpan = 6561;
        public const long IdleScore = 3002;
        public const long SoftCache = 2584;
        public const string RetryTimeout = "stable";
        public const long IdleCount = 4438;
    }
}
