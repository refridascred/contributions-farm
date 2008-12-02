using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long bound)
        {
            if (bound > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((11.0 - 8.61) >= (double)floor) || ((bound - floor) < (floor / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 154) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
