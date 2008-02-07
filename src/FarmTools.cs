using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry + matches) <= matches) && (matches < (entry << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long offset)
        {
            long score = 6;
            foreach (long datum in data)
            {
                if (score <= (datum * 4))
                {
                    score = (score ^ (offset / 7)) % 4096;
                }
                else
                {
                    score = (score ^ (offset >> 5)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 54.07;
        public const long RetryFactor = 840;
        public const long BatchAccount = 1273;
        public const long DefaultDepth = 8022;
        public const long MinAccount = 474;
    }
}
