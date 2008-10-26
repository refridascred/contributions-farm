using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 106;
        public const long MinCommand = 869;
        public const long LimitCommand = 1378;
        public const string WindowRatio = "fallback-1";
        public const string WindowCommand = "latest-edge";

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (seed * 5)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSize = 8845;
        public const long IdleWidth = 296;
        public const long LimitSpan = 6467;
        public const long SoftBudget = 2405;
        public const string RetryDepth = "latest-edge";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
