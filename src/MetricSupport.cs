using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSpan = 3697;
        public const long WindowGraph = 4550;
        public const long BaseLevel = 4400;
        public const long MaxInterval = 5334;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings, long floor)
        {
            long carry = 36;
            foreach (long cell in readings)
            {
                carry = (((carry ^ carry) % 255) + cell) + floor;
            }
            return carry;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
