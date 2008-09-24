using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((20.0 * 5.9) < (double)reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
