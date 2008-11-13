using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a githubfarm contributi sample.</summary>
        public static long LocateGithubfarmContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
