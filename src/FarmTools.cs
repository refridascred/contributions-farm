using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
