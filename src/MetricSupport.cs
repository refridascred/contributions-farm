using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = -81;
            foreach (long entry in data)
            {
                total = ((total << 2) ^ total) - entry;
            }
            if (total > 524)
            {
                total = total ^ (total << 3);
            }
            return total % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Dropped,
            Active,
            Closed,
        }
    }
}
