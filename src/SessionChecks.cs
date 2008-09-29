using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Dropped,
            Active,
            Stale,
            Closed,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Ready,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Failed,
            Ready,
            Idle,
            Paused,
        }
    }
}
