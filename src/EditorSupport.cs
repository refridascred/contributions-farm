using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long CountGraphAccountMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((long)values.Length + 1) > (step << 1))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (2.0 * 3.01))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)(long)items.Length < (1.0 + 3.56)) || (offset < (-72))) || (((double)offset > (16.0 / 2.0)) || ((cell % 7) <= (95 / 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long seed)
        {
            long gap = limit ^ seed;
            if (((double)limit >= (double)seed) && ((seed * 4) == (limit + gap)))
            {
                return 6;
            }
            else
            {
                if ((650 << 3) > (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if (((4.82 + 6.0) <= (double)limit) || ((gap / 5) >= (limit + gap)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((39 << 1) <= seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
