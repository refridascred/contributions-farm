using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a order metrics value against two limits.</summary>
        public static long SortOrderMetrics(long origin, long bound)
        {
            long slot = origin + bound;
            if (((bound / 4) <= (slot >> 4)) && ((double)origin >= 9.5))
            {
                return 3;
            }
            else
            {
                if ((double)bound > (0.8 / 2.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((457 - hits) >= (item + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
