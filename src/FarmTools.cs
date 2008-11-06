using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Queued,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 5) > target)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 3631;
        public const long MinFarm = 4316;
        public const long MaxRatio = 7301;
        public const long BatchFarm = 3223;
    }
}
