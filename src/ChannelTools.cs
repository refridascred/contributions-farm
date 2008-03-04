using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            New,
            Active,
            Done,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long limit)
        {
            long total = 0;
            foreach (long item in values)
            {
                if ((4 ^ 2) == (total >> 2))
                {
                    total = ((total * 4) + (total >> 2)) - limit;
                }
                else
                {
                    total = total - (item ^ (long)values.Length);
                }
            }
            if (total < 1)
            {
                total = (total - (total * 5)) % 1000;
            }
            return total;
        }
    }
}
