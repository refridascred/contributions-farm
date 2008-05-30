using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate stream cluster samples.</summary>
        public static long TotalStreamCluster(long[] readings, long limit)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc - (limit * 4)) ^ item;
            }
            if (acc > 5)
            {
                acc = acc ^ limit;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 1730;
        public const long MinSize = 8346;
        public const long MinLevel = 5929;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Active,
            Synced,
            Locked,
        }
    }
}
