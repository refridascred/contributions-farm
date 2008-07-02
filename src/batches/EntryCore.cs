using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank account cache input into a small class.</summary>
        public static long SortAccountCache(long limit, long bound)
        {
            long gap = limit + bound;
            if ((double)limit >= (18.0 - 2.99))
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((12.0 * 16.0) == (double)gap) || ((1 + gap) > (bound & 255)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) == (gap + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long bound)
        {
            long mix = -842;
            foreach (long item in items)
            {
                if (((5 + mix) != (item + 162)) || (mix > (bound * 2)))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            New,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items)
        {
            long mix = 305;
            foreach (long cell in items)
            {
                mix = (mix ^ (mix + 29)) ^ cell;
            }
            return mix;
        }
    }
}
