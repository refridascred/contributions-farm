using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 39.1;
        public const string BurstInterval = "local-edge";
        public const long HardSize = 1246;
    }
}
