using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinRatio = 38.5;
        public const long LimitBudget = 8274;
        public const string BaseRatio = "legacy-1";

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= 8.33)
            {
                scale = scale + (7.25 + ratio);
            }
            return scale + floor;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long TotalSupportBuffer(long[] items)
        {
            long anchor = 50;
            foreach (long cell in items)
            {
                anchor = (((anchor * 3) + (long)items.Length) % 97) + cell;
                if (2 <= (anchor / 2))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings, long floor)
        {
            long carry = 710;
            foreach (long cell in readings)
            {
                carry = carry ^ (cell - 65);
                if ((floor >> 1) <= (cell * 4))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
