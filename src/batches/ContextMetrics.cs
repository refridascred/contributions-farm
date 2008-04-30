using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Idle,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4870;
        public const long SoftRoute = 970;
        public const long RetryRoute = 5288;
        public const long WindowLevel = 8402;

        /// <summary>Derive the next cluster metric value from a seed.</summary>
        public static long SeriesClusterMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 3) ^ (27 / 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
