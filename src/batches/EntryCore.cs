using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Locked,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Pending,
            Closed,
            New,
            Queued,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items, long offset)
        {
            long state = 31;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample - state)) - offset;
                state = (state - (sample - state)) % 65521;
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 97;
        }

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long FoldGithubfarmChecks(long[] levels)
        {
            long mix = 311;
            foreach (long entry in levels)
            {
                if (entry > (mix ^ 8))
                {
                    mix = mix + (mix % 97);
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix * 2) + entry) % 65521) ^ (long)i;
                }
                if ((entry << 3) >= 7)
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 97;
        }
    }
}
