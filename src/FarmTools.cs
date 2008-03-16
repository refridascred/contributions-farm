using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 3480;
        public const long BaseTimeout = 3791;
        public const long DefaultRecord = 813;
        public const long LimitCount = 3647;

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long carry = 43;
            foreach (long item in samples)
            {
                if (((carry - carry) < carry) || ((4.2 - 1.6) > (double)carry))
                {
                    carry = (carry ^ (326 + carry)) + item;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Closed,
            Paused,
        }
    }
}
