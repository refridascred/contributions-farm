using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long seed)
        {
            long score = 42;
            foreach (long cell in values)
            {
                if ((double)seed < (double)score)
                {
                    score = (score + (score % 2)) ^ cell;
                }
            }
            if (score > 5)
            {
                score = (score - (seed + seed)) % 255;
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches + 31) <= (entry - entry))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
