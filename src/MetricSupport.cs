using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Ready,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally * 2) <= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
