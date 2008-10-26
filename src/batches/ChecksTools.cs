using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 9428;
        public const double RetryScore = 16.22;
        public const long WindowScore = 2572;
        public const string SoftPayload = "legacy-v2";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
