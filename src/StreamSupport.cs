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

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long limit, long offset)
        {
            long lane = limit - offset;
            if ((limit & 3) >= lane)
            {
                return 8;
            }
            else
            {
                if (((limit / 4) <= (limit * 2)) && ((limit + limit) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
