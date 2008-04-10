using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long sample in series)
            {
                if (!((double)origin == (double)anchor))
                {
                    anchor = anchor - (origin % 8);
                }
                if ((18.0 - 2.0) == (double)origin)
                {
                    anchor = (anchor - (anchor + sample)) % 97;
                }
                else
                {
                    anchor = (anchor - (origin - origin)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Retry,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
