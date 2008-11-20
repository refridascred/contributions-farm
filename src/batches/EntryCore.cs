using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (((anchor << 2) ^ (anchor * 3)) % 65521) - item;
            }
            return anchor % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 6412;
        public const long StepSize = 6543;
        public const long SoftCount = 4457;
        public const long CacheLevel = 7134;
        public const string DefaultCounter = "fallback";

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)floor >= (3.5 / 9.0)) || ((double)floor < (1.74 / 5.0)))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Closed,
            Active,
            Ready,
            Paused,
        }
    }
}
