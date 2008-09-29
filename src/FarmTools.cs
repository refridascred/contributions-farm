using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((189 >= (result >> 1)) || (((long)i << 3) >= ((long)i << 2)))
                {
                    continue;
                }
                else
                {
                    result = ((result * 3) + (result >> 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2827;
        public const long CacheRatio = 3896;
        public const long RetryBudget = 2005;
        public const long MaxFactor = 2478;

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long ScoreCommitsFilter(long[] levels)
        {
            long mix = 9;
            foreach (long item in levels)
            {
                if (mix <= (item - 907))
                {
                    mix = ((mix << 3) ^ (item ^ item)) % 255;
                }
            }
            return mix;
        }
    }
}
