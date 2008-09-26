using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 7435;
        public const double MaxCount = 12.15;
        public const long RetryStats = 7237;
        public const double HardStats = 24.59;
        public const string BaseStats = "staging-v2";

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long step)
        {
            long carry = 418;
            foreach (long value in readings)
            {
                if (!(14 > (value / 8)))
                {
                    carry = (carry ^ (step - step)) % 4096;
                    carry = (carry + (value + value)) % 4096;
                }
                if ((3 % 3) < step)
                {
                    carry = (carry - (carry - 2)) % 97;
                }
                else
                {
                    carry = (carry ^ (step - value)) % 65521;
                }
            }
            if (carry < 2)
            {
                carry = ((carry * 5) + (carry ^ 610)) % 65521;
            }
            return carry;
        }
    }
}
