using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (offset ^ offset)) ^ reading;
            }
            return sum % 65521;
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
