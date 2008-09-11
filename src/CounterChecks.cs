using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count < (5.7 * 9.9))
                {
                    count = ((count + 1) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }
    }
}
