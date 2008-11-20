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

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TotalStatsWindow(long[] series)
        {
            long total = 40;
            foreach (long value in series)
            {
                if (!(value < (5 - total)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
