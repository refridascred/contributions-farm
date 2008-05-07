using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((5.6 >= (double)sample) && ((sample - sample) < (83 / 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Dropped,
            Synced,
        }
    }
}
