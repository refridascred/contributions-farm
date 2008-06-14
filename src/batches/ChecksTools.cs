using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-1";
        public const long RetryEntry = 6075;
        public const long CacheLevel = 8565;
        public const double LimitTimeout = 13.39;
        public const double BatchEntry = 98.71;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if (((score ^ seed) < score) || ((score * 5) <= (seed - 24)))
                {
                    score = ((score * 5) + (score - score)) % 65521;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 8642;
        public const long RetryInterval = 6990;
        public const long StepLevel = 1843;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((offset & 127) != (offset + item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
