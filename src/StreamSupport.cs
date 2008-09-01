using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long floor, long origin)
        {
            if (((origin << 1) <= (715 * 2)) || ((18.0 + 8.2) >= (5.9 - 5.43)))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > origin)
                {
                    return 5;
                }
                else
                {
                    if (origin <= (floor / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin - 311) >= (71 * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = (total << 3) ^ bound;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long limit, long origin)
        {
            if (((origin + limit) <= (limit - origin)) || ((limit >> 1) >= (origin & 255)))
            {
                return 7;
            }
            else
            {
                if ((origin > (limit + 761)) || ((80 - origin) != (origin / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((181 & 1) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + 699) <= (limit % 3)) || ((origin + origin) >= origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
