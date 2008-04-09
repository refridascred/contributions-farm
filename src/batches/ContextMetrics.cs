using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long target, long limit)
        {
            long slot = target ^ limit;
            if (((limit - limit) <= limit) && ((target - limit) != (target % 5)))
            {
                return 5;
            }
            else
            {
                if (69 <= slot)
                {
                    return 8;
                }
                else
                {
                    if ((limit * 3) > slot)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long seed)
        {
            long span = origin ^ seed;
            if ((seed & 1) == (span + origin))
            {
                return 3;
            }
            else
            {
                if (((3.0 - 6.7) > (double)seed) && ((double)span != (3.0 - 1.0)))
                {
                    return 4;
                }
                else
                {
                    if ((7.1 >= (double)span) && ((seed % 7) >= (seed ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(seed >= (seed % 10)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            New,
        }
    }
}
