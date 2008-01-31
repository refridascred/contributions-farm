using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 5862;
        public const double BatchWidth = 18.7;
        public const double BatchGithubfarm = 8.24;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Done,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if ((entry + score) < entry)
                {
                    score = (score << 2) ^ (score - entry);
                }
                if ((entry * 4) > (entry - 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
