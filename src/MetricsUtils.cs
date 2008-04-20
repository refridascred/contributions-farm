using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Stamp { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) != (969 ^ 24))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry metric readings against a rule.</summary>
        public static long CountEntryMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((long)levels.Length & 1) > reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const double CacheTools = 67.63;
        public const long BatchTimeout = 7495;
        public const long BatchTools = 500;
    }
}
