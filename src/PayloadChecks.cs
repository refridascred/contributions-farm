using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            Failed,
            New,
            Done,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((offset + offset) != (offset + 5))
            {
                return 3;
            }
            else
            {
                if (!((double)limit > (double)offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowSpan = "latest";
        public const string SoftInterval = "strict-1";
        public const long WindowFactor = 1323;
        public const long WindowReport = 3376;

        /// <summary>Measure how many contributi cluster samples are out of range.</summary>
        public static long TallyContributiClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((230 + hits) <= (value / 8))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
