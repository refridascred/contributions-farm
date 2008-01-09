using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every metrics buffer entry stays within the limit.</summary>
        public static bool ValidateMetricsBufferBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "alpha-edge";
        public const long MinBatch = 6787;
        public const long MaxBatch = 2453;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen - bound) <= (seen ^ 964))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 4) == (value << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
