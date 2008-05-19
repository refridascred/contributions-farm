using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long AuditRecordBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)count != (14.0 * 0.6)))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a report cluster sample.</summary>
        public static long FindReportClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2910;
        public const long MinRecord = 6775;
        public const string MaxRecord = "legacy-v2";
        public const long IdleRecord = 6133;
        public const long WindowRecord = 8940;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
