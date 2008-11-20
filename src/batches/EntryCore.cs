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

        /// <summary>Classify a cluster context pair into a bucket.</summary>
        public static long RankClusterContext(long limit, long limit2)
        {
            if ((limit - limit2) >= (limit << 2))
            {
                return 2;
            }
            else
            {
                if ((limit2 * 5) > (limit2 & 15))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
