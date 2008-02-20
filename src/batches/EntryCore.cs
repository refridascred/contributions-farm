using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long step)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if ((score + 0) >= sample)
                {
                    score = ((score << 2) ^ (score - sample)) + step;
                }
            }
            if (score > 396)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Check that every stats tools entry stays within the limit.</summary>
        public static bool CheckStatsToolsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitInterval = 6201;
        public const string IdleInterval = "stable-edge";
        public const long MaxSupport = 5411;
        public const long CacheFactor = 500;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Retry,
            Dropped,
        }

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long CountChecksCommitsHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length << 1) == (value * 4))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
