using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long offset)
        {
            long score = 4;
            foreach (long item in series)
            {
                score = ((score << 3) ^ (item ^ score)) + offset;
            }
            return score;
        }

        /// <summary>Check that every format report entry stays within the limit.</summary>
        public static bool ValidateFormatReportBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
