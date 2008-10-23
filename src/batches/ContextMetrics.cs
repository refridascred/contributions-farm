using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(target < (matches ^ 428)) && ((cell + 14) < (matches + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many account session samples are out of range.</summary>
        public static long CountAccountSessionHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(((seed ^ 29) != (item + item)) && (seed <= (0 - (-5)))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
