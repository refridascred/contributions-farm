using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((699 - item) == (count + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            New,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Synced,
            Stale,
            Idle,
            Retry,
        }
    }
}
