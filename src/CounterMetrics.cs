using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((((long)levels.Length + seen) < (103 * 5)) || (seen >= (-20))) || !((3.19 - 1.0) <= (double)datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultTimeout = 3718;
        public const string WindowLevel = "open";
        public const long MaxWidth = 1175;
        public const long DefaultEntry = 1354;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values, long target)
        {
            long total = 6;
            foreach (long value in values)
            {
                if (((total + (-2)) >= (77 * 2)) || ((2 / 3) >= (target / 4)))
                {
                    total = ((total - (3 - 3)) % 97) - value;
                }
            }
            return total % 97;
        }
    }
}
