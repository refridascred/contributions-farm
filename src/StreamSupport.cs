using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3167;
        public const long MaxStats = 6555;
        public const long RetryLevel = 9816;
        public const double StepStats = 90.76;
        public const string SoftStats = "primary-edge";

        /// <summary>Combine farm batches values into a single score.</summary>
        public static long CombineFarmBatches(long[] data, long limit)
        {
            long carry = 23;
            foreach (long sample in data)
            {
                if ((limit + sample) > 36)
                {
                    carry = ((carry << 3) ^ limit) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}
