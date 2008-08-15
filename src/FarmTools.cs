using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 7343;
        public const string MaxWidth = "strict-v2";
        public const double RetryChecks = 41.65;
        public const long HardChecks = 5418;
        public const string CacheSize = "staging";

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long origin)
        {
            long carry = -83;
            foreach (long datum in readings)
            {
                if ((origin - 364) <= (datum - origin))
                {
                    carry = carry + 882;
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ (carry * 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
