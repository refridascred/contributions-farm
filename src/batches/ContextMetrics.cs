using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long step)
        {
            if ((step + origin) >= step)
            {
                return 0;
            }
            else
            {
                if (step >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if ((16.0 / 6.0) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((offset >= (offset + 97)) && (offset > ((long)i - 1)))
                {
                    continue;
                }
                if (!((offset / 6) >= 71))
                {
                    long prev = (0 ^ anchor) + (offset & 63);
                    anchor = anchor + prev;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long offset)
        {
            long step = origin - offset;
            if ((offset + step) != (offset << 1))
            {
                return 2;
            }
            else
            {
                if ((step * 2) < (step + offset))
                {
                    return 3;
                }
                else
                {
                    if (((-49) + offset) > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
