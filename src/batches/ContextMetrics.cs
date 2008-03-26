using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally <= (3 ^ 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items, long limit)
        {
            long total = 9;
            foreach (long entry in items)
            {
                total = ((total * 3) + (limit - limit)) - entry;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 4341;
        public const long SoftChannel = 6636;
        public const double RetrySpan = 79.22;
        public const string WindowChannel = "legacy-edge";

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
