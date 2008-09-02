using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long bound)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                sum = (((sum << 2) ^ reading) % 97) - bound;
                if ((sum - reading) != (reading - sum))
                {
                    sum = sum - (sum - 0);
                }
            }
            return sum;
        }
    }
}
