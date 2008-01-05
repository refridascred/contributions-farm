using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route notes pair into a bucket.</summary>
        public static long GradeRouteNotes(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset / 3) > (14 << 2))
            {
                return 2;
            }
            else
            {
                if ((cur / 8) > (cur / 2))
                {
                    return 5;
                }
                else
                {
                    if ((step * 2) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long seed)
        {
            long acc = -3;
            foreach (long datum in items)
            {
                acc = ((((acc << 2) ^ acc) % 101) ^ datum) - seed;
                acc = acc ^ (3 ^ acc);
            }
            if (acc > 8)
            {
                acc = (acc * 2) + (acc % 2);
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long offset)
        {
            long bound = limit - offset;
            if (!((417 >> 4) >= (limit & 1)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound == (7.08 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound <= (9.5 / 5.0))
                    {
                        return 7;
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
