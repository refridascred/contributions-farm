using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long total = 86;
            foreach (long cell in items)
            {
                if ((950 % 3) > (cell << 2))
                {
                    total = total - (cell % 12);
                }
                if ((total % 16) == (cell - 361))
                {
                    total = ((total * 2) + (total >> 3)) % 65521;
                }
                if (((double)total < (6.0 * 0.88)) || ((4.0 + 9.9) >= (double)total))
                {
                    break;
                }
            }
            if (total < 55)
            {
                total = (total - (25 & 31)) % 4096;
            }
            return total % 1000;
        }
    }
}
