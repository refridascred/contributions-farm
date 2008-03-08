using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Synced,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (((result << 2) ^ (33 % 24)) % 65521) + sample;
            }
            return result % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((double)6 > (double)target)
            {
                return 8;
            }
            else
            {
                if (((6.2 / 5.0) <= (double)target) && (2 < (target + target)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
