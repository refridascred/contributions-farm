using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Queued,
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 6547;
        public const long MinSpan = 6365;
        public const double LimitLevel = 19.18;
        public const string MinBudget = "fallback-1";
        public const long RetryBudget = 6838;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
