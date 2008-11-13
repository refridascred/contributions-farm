using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long total = -35;
            foreach (long sample in values)
            {
                if ((sample << 2) <= (sample - total))
                {
                    total = (total ^ (sample ^ total)) % 65521;
                }
            }
            return total % 1000;
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
