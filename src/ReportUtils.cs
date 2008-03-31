using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a stats account value against two limits.</summary>
        public static long SortStatsAccount(long offset, long target)
        {
            long slot = offset ^ target;
            if (offset > slot)
            {
                return 3;
            }
            else
            {
                if (offset > target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double offset)
        {
            double mean = (offset / 4.0) + (19.0 - offset);
            if (mean > (double)537)
            {
                mean = mean + (double)465;
            }
            return mean + (bias + bias);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long carry = 74;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + (carry % 2)) % 1000) ^ reading;
            }
            if (carry > 621)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series)
        {
            long mix = 1;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ value) % 255;
            }
            if (mix > 17)
            {
                mix = ((mix << 2) ^ (6 << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 9123;
        public const long CacheRecord = 9585;
        public const string DefaultRecord = "alpha-v2";
        public const long WindowRecord = 3027;
    }
}
