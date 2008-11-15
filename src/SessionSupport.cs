using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate account farm samples.</summary>
        public static long TotalAccountFarm(long[] series, long target)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if (total < (datum + target))
                {
                    total = (total ^ (target ^ datum)) % 1000;
                }
                if (((target + 9) <= (total + total)) || ((double)datum >= (3.3 + 8.4)))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = ((total * 2) + (target ^ 9)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
