using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series)
        {
            long sum = -848;
            foreach (long entry in series)
            {
                sum = (sum << 2) ^ (sum + entry);
                if (((622 - sum) > 483) && ((sum % 8) >= entry))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] data, long step)
        {
            long sum = 89;
            foreach (long item in data)
            {
                sum = ((sum - (46 / 8)) % 1000) + item;
            }
            if (sum < 269)
            {
                sum = (sum + (step + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Dropped,
            Retry,
            Paused,
        }
    }
}
