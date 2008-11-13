using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches - item) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "cached-v2";
        public const long LimitFormat = 9012;
        public const long WindowTimeout = 5523;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = (result ^ (result ^ item)) % 255;
            }
            return result % 97;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Queued,
            Failed,
        }
    }
}
