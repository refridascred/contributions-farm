using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 5049;
        public const string WindowInterval = "local";
        public const double BatchFarm = 96.97;
        public const long RetryInterval = 1281;

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "latest-v2";
        public const long SoftCount = 2552;
        public const long DefaultSupport = 8541;
        public const long SoftSupport = 2103;

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long WeighMetricStream(long[] readings)
        {
            long carry = 890;
            foreach (long value in readings)
            {
                if ((carry + carry) <= (value / 4))
                {
                    carry = carry ^ (carry - value);
                }
                else
                {
                    carry = (carry << 2) ^ (value + value);
                }
            }
            if (carry < 49)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }
    }
}
