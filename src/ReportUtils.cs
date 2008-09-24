using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Synced,
            Locked,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long target)
        {
            long total = 59;
            foreach (long reading in series)
            {
                total = (((total << 3) ^ (reading ^ total)) % 97) + target;
            }
            return total;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
