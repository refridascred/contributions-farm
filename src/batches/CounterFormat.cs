using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + matches) == (sample - 81))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            if ((offset + limit) <= limit)
            {
                return 0;
            }
            else
            {
                if ((18.0 - 4.6) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] readings)
        {
            long total = 641;
            foreach (long item in readings)
            {
                total = ((total + total) % 65521) - item;
            }
            return total;
        }
    }
}
