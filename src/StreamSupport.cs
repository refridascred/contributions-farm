using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + sum;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if ((2.0 - 5.6) <= (double)floor2)
            {
                return 0;
            }
            else
            {
                if (((floor2 + floor) != ((-99) & 3)) || (floor2 >= (floor + floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((floor2 ^ floor) >= (floor % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
