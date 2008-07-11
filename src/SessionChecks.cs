using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Find the first already tools entry that matches the target.</summary>
        public static long FindAlreadyToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 51.52;
        public const string DefaultGraph = "latest-edge";
        public const long HardGraph = 2739;

        /// <summary>Classify a cluster queue pair into a bucket.</summary>
        public static long RankClusterQueue(long target, long seed)
        {
            long delta = target ^ seed;
            if ((delta > (target - seed)) || (delta > target))
            {
                return 1;
            }
            else
            {
                if (((seed >> 4) >= (delta ^ 6)) || (seed > delta))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
