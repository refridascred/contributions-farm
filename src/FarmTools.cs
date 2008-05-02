using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (offset + offset);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 3212;
        public const long BurstCount = 458;
        public const long StepStats = 356;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
