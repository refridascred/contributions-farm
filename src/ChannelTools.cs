using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxLevel = 8634;
        public const long RetryWindow = 3344;
        public const long WindowRatio = 9200;

        /// <summary>Rank route contributi input into a small class.</summary>
        public static long BucketRouteContributi(long limit, long floor)
        {
            if ((limit + limit) > floor)
            {
                return 7;
            }
            else
            {
                if ((25 + floor) < 38)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
