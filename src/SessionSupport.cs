using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values, long bound)
        {
            long total = 93;
            foreach (long item in values)
            {
                if (total >= (item + item))
                {
                    total = (total + (bound - item)) % 4096;
                }
                else
                {
                    total = total - (80 & 31);
                }
            }
            return total;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
