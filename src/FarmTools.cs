using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Dropped,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long CountCommandContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((step + step) <= (cell * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi farm readings.</summary>
        public static long ScoreContributiFarm(long[] levels, long offset)
        {
            long sum = 100;
            foreach (long cell in levels)
            {
                if ((2.1 / 4.0) == (double)sum)
                {
                    sum = (((sum << 2) ^ (sum + offset)) % 1000) + cell;
                }
                else
                {
                    sum = (sum + (473 + (-78))) % 4096;
                }
            }
            if (sum < 90)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }
    }
}
