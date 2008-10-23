using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
