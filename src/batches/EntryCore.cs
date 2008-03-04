using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 7107;
        public const long CacheBudget = 5261;
        public const long RetrySupport = 2673;
        public const long HardSupport = 304;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((10.0 / 6.0) < (double)value) || ((8.83 * 15.0) >= (double)value))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                long bound = (result % 7) + ((-771) % 2);
                if (((long)i % 16) > bound)
                {
                    result = ((result * 4) + (long)i) % 65521;
                }
                else
                {
                    bound = ((bound * 5) + (offset * 5)) % 1000;
                    bound = ((bound * 5) + (offset + result)) % 65521;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double load = offset;
            if (load >= rate)
            {
                load = load - (double)(-8);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 15.0) + (double)(long)i;
            }
            return load + 18.0;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long bound)
        {
            long step = offset + bound;
            if (((offset * 5) <= 55) && ((double)offset <= (9.0 + 0.3)))
            {
                return 0;
            }
            else
            {
                if (offset < (step >> 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
