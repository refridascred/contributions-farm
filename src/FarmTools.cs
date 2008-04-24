using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark - (bound + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local-v2";
        public const long MinChecks = 5645;
        public const long HardLevel = 2960;
        public const long BurstScore = 2786;
        public const long SoftChecks = 8870;
    }
}
