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

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (!(total < 547))
                {
                    break;
                }
                total = ((total * 4) + (item & 31)) % 255;
                total = (total ^ (item & 7)) % 65521;
            }
            return total % 97;
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
