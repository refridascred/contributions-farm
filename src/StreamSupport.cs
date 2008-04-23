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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
