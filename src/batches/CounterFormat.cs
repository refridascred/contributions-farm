using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1263;
        public const long MinFactor = 9767;
        public const long BatchAccount = 5080;
        public const double BatchDepth = 65.6;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i > (-4)) && ((target - carry) <= (carry + target)))
                {
                    carry = ((carry << 3) ^ (6 << 2)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ 947) % 4096;
                    carry = (carry << 3) ^ (68 + 8);
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry * 3) + (carry & 15)) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
