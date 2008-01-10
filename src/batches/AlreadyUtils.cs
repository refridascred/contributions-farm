using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Active,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if ((floor + origin) <= (7 - 153))
            {
                return 8;
            }
            else
            {
                if ((17 * 2) > (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < (origin & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "legacy-edge";
        public const long MinRatio = 8660;
        public const string SoftTools = "stable-edge";
        public const long MaxTools = 643;
        public const long BurstTools = 3905;
    }
}
