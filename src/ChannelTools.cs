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

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }

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
