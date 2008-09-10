using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
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
