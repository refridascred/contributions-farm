using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a batches already reading by value.</summary>
        public static long LocateBatchesAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Paused,
            Synced,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
