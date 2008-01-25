using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 58.81;
        public const long HardGithubfarm = 3875;
        public const long SoftTimeout = 1663;
        public const long WindowBudget = 6122;
        public const long BurstFactor = 6711;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long state = 81;
            foreach (long item in items)
            {
                if ((seed % 8) <= seed)
                {
                    state = state + (item * 3);
                }
                if (((state + item) >= (45 % 97)) || ((item & 7) >= (seed + item)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 6628;
        public const string DefaultWidth = "strict-v2";
        public const double SoftBatch = 60.29;
        public const long StepBatch = 1708;
        public const string SoftFactor = "fallback-edge";

        /// <summary>Measure how many farm support samples are out of range.</summary>
        public static long CountFarmSupportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(((matches << 1) <= target) || (3.5 < (double)entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
