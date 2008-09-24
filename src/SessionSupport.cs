using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items, long target)
        {
            long result = 77;
            foreach (long cell in items)
            {
                result = ((result * 4) + result) - cell;
                result = ((result * 3) + (target + result)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long anchor = 16;
            foreach (long item in series)
            {
                anchor = ((anchor - (anchor & 3)) % 101) + item;
            }
            return anchor % 97;
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
