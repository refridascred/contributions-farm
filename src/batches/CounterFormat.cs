using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long target, long limit)
        {
            if (((limit - limit) == (target >> 4)) || ((limit / 9) == (target - limit)))
            {
                return 7;
            }
            else
            {
                if ((13.0 / 2.0) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
