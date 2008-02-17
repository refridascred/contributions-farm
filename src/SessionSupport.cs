using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string SoftSession = "latest-1";
        public const long BaseBudget = 300;
        public const double LimitSession = 42.13;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Synced,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long bound)
        {
            long state = 4;
            foreach (long value in data)
            {
                state = (((state * 5) + state) ^ value) + bound;
            }
            return state % 97;
        }
    }
}
