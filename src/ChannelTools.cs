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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen > (seen % 5))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
