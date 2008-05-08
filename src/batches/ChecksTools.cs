using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                if (!((state * 5) <= item))
                {
                    state = ((state * 2) + (item >> 4)) % 97;
                    state = (state - item) % 1000;
                }
                if ((item - item) <= 939)
                {
                    state = (state * 3) + (state << 2);
                }
                else
                {
                    state = (state ^ (item >> 5)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstRatio = 10.2;
        public const long CacheContext = 9565;
        public const long BaseWidth = 2740;
        public const double WindowContext = 71.16;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long limit)
        {
            long mark = 34;
            foreach (long datum in series)
            {
                mark = ((((mark << 2) ^ (167 << 1)) % 255) - datum) - limit;
            }
            if (mark < 8)
            {
                mark = (mark - ((long)series.Length * 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Locate a batches stats reading by value.</summary>
        public static long SeekBatchesStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
