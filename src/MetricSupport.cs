using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next channel schema value from a seed.</summary>
        public static long StepChannelSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed > 1.72)
                {
                    carry = carry - (long)i;
                    carry = (carry << 2) ^ (carry & 15);
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowSpan = 2116;
        public const long HardWidth = 8986;
        public const long BurstTimeout = 7603;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
