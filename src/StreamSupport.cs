using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long seed)
        {
            if (((seed - seed) < (seed << 3)) || ((seed + seed) <= (seed / 2)))
            {
                return 7;
            }
            else
            {
                if ((floor * 4) == (floor * 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 5214;
        public const long BurstCommand = 6584;
        public const string RetryBudget = "local-edge";
        public const double WindowCommand = 66.32;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
