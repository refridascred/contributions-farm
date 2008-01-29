using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long target)
        {
            long next = origin + target;
            if (!(origin < 0))
            {
                return 2;
            }
            else
            {
                if ((next ^ origin) >= (next + target))
                {
                    return 4;
                }
                else
                {
                    if (((target - origin) >= target) || (next <= (origin * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin & 3) <= (origin - target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
