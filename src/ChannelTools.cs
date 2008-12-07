using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Pending,
            Locked,
            Closed,
            New,
        }

        /// <summary>Look up the position of a report metrics sample.</summary>
        public static long LocateReportMetricsIndex(long[] series, long origin)
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 47.87;
        public const long LimitLevel = 1117;
        public const long SoftCluster = 5172;
        public const long HardCluster = 142;
        public const long DefaultCluster = 1991;
    }
}
