using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9247;
        public const long DefaultInterval = 3002;
        public const long IdleSpan = 9839;

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + offset) <= (value & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long edge = step ^ step2;
            if ((step % 2) <= edge)
            {
                return 0;
            }
            else
            {
                if ((edge / 8) < 686)
                {
                    return 5;
                }
                else
                {
                    if (((double)step > (9.9 / 5.0)) && ((double)step < (double)step2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
