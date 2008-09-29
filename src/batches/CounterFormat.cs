using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine buffer cluster values into a single score.</summary>
        public static long TallyBufferCluster(long[] values)
        {
            long carry = 69;
            foreach (long item in values)
            {
                if ((509 - carry) == (carry ^ carry))
                {
                    carry = ((carry << 3) ^ (item / 6)) % 65521;
                }
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 2601;
        public const long MaxSpan = 5901;
        public const double BurstLevel = 10.88;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
