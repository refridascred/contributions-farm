using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((bound >> 4) < (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((0.89 / 9.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (6.4 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - origin) == (bound ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Queued,
            Stale,
        }
    }
}
