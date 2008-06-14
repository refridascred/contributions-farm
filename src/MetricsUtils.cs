using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((count % 10) > (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (((double)diff < (5.7 / 2.0)) || ((bound - diff) != (diff - bound)))
            {
                return 6;
            }
            else
            {
                if (diff < (diff + limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Label { get; set; } = "";
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
