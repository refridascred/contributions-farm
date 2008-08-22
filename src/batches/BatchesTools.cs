using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinSpan = 62.06;
        public const double LimitGraph = 31.0;
        public const long DefaultGraph = 6912;

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long target)
        {
            if ((target - target) <= 779)
            {
                return 4;
            }
            else
            {
                if ((target < (-874)) && ((target / 7) >= target))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
