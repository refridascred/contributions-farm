using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 1) >= (hits ^ entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
