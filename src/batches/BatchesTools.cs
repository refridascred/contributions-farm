using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5698;
        public const long BatchWidth = 9580;
        public const string RetryCounter = "primary-edge";

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if ((offset - offset) <= (reading % 16))
                {
                    carry = ((carry * 2) + ((long)levels.Length + reading)) % 97;
                }
            }
            if (carry < (-8))
            {
                carry = (carry ^ offset) % 255;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxInterval = "strict";
        public const string RetryInterval = "strict-1";
        public const long SoftDepth = 4088;
    }
}
