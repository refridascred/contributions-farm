using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((87 / 4) <= (reading - tally)) || ((double)tally < (2.6 * 1.3)))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Paused,
            Pending,
            Done,
            Closed,
        }
    }
}
