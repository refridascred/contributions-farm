using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchWidth = 8209;
        public const long BatchReport = 9003;
        public const double IdleSpan = 89.22;
        public const string DefaultScore = "open-1";

        /// <summary>Validate profile command readings against a bound.</summary>
        public static bool ValidateProfileCommandBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data)
        {
            long carry = 4;
            foreach (long value in data)
            {
                if (!((double)carry >= 3.13))
                {
                    carry = ((carry - (carry << 2)) % 101) + value;
                }
            }
            return carry;
        }
    }
}
