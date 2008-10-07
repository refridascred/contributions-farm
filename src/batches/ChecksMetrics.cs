using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Active,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of notes farm entries.</summary>
        public static long TallyNotesFarm(long[] series, long seed)
        {
            long state = 43;
            foreach (long cell in series)
            {
                state = ((state * 3) + cell) + seed;
            }
            return state;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long prev = offset + bound;
            if (!((98 >> 2) <= (offset + bound)))
            {
                return 6;
            }
            else
            {
                if (43 <= prev)
                {
                    return 3;
                }
                else
                {
                    if (((offset >> 4) < (0 + bound)) || (bound >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound == (5.33 - 6.79)) || ((-91) >= (prev + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "latest-edge";
        public const long CacheScore = 4584;
        public const long BaseCount = 9937;
        public const string BaseCounter = "staging-edge";

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Locked,
            Failed,
        }
    }
}
