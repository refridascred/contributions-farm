using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long acc = 757;
            foreach (long cell in values)
            {
                if ((double)acc > 4.5)
                {
                    acc = (((acc << 2) ^ (acc << 2)) + cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long bound)
        {
            long edge = limit + bound;
            if (edge < (bound << 3))
            {
                return 3;
            }
            else
            {
                if (((870 + 65) <= (limit + edge)) || (8 > limit))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (621 - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5.4 > (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 9905;
        public const string CacheScore = "cached-edge";
        public const double MaxTimeout = 50.78;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Synced,
            Active,
            Done,
            Queued,
        }
    }
}
