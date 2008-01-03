using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 73.53;
        public const long CacheDepth = 3887;
        public const long BaseSchema = 4146;
        public const long BatchScore = 6028;
        public const long DefaultWidth = 8682;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
