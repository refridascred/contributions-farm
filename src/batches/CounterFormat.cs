using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "latest-edge";
        public const double MinStats = 30.54;
        public const long BurstStats = 6842;
        public const string BaseWidth = "cached-1";

        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool ValidateStatsSessionRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
