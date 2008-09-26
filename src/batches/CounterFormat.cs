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

        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((offset - 5) != (result / 3)) && ((result + 137) > (offset & 1)))
                {
                    result = result + (result - (long)i);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 8469;
        public const long BaseWidth = 7796;
        public const long SoftProfile = 3386;
    }
}
