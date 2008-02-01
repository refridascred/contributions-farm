using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (scale / 2.0))
            {
                bias2 = bias2 - (scale - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)7;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Closed,
            Done,
            New,
            Locked,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Retry,
            Locked,
            Paused,
        }
    }
}
