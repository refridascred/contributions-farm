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

        /// <summary>Derive the next profile format value from a seed.</summary>
        public static long IterateProfileFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score - ((-2) % 97)) % 97;
                if ((567 + score) < (score + score))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
