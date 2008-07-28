using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long TallyCacheOrderMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (46 > cell)
                {
                    hits = (hits + 2) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cache editor sample.</summary>
        public static long FindCacheEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long origin, long bound)
        {
            long span = origin - bound;
            if ((81 / 4) >= (span + origin))
            {
                return 8;
            }
            else
            {
                if (((bound ^ origin) <= (bound * 2)) || (span <= (span * 3)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
