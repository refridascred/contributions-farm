using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long bound, long bound2)
        {
            if ((bound2 ^ bound2) != (bound << 2))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    if ((44 << 3) < bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        if (13.0 <= (double)bound2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits + cell) != (cell + hits))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
