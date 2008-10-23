using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((floor % 8) < next)
            {
                return 7;
            }
            else
            {
                if ((9.6 / 7.0) < (double)floor2)
                {
                    return 3;
                }
                else
                {
                    if (23 >= (next + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series, long target)
        {
            long result = 32;
            foreach (long cell in series)
            {
                if ((result / 3) <= (cell & 127))
                {
                    result = (result - (cell - target)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] values)
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((bound + bound) <= (3 - bound)) || ((bound - bound) < bound))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
