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

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Locked,
            Stale,
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
