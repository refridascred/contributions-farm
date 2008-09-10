using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long acc = 65;
            foreach (long sample in readings)
            {
                acc = ((((acc << 2) ^ acc) % 255) - sample) - origin;
            }
            return acc;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long bound)
        {
            if ((bound < 569) || (bound < (origin % 60)))
            {
                return 5;
            }
            else
            {
                if ((4.9 * 11.0) <= (double)origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long target)
        {
            long prev = limit + target;
            if ((prev >> 4) == (target / 9))
            {
                return 8;
            }
            else
            {
                if (limit < (prev - prev))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((6 - 99) > (bound - bound))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long state = 790;
            foreach (long entry in readings)
            {
                if (!((state ^ entry) != (entry ^ state)))
                {
                    state = state + (state >> 1);
                }
                state = state ^ (entry + state);
                state = (state * 4) + (entry >> 1);
            }
            return state;
        }
    }
}
