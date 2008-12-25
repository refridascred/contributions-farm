using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long step, long origin)
        {
            long gap = step - origin;
            if ((origin / 5) > (step ^ step))
            {
                return 4;
            }
            else
            {
                if (((origin ^ 12) < (origin / 9)) && ((double)gap >= 20.0))
                {
                    return 5;
                }
                else
                {
                    if (step <= ((-77) % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 3) > (gap >> 3))
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
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series)
        {
            long total = 473;
            foreach (long value in series)
            {
                if ((total % 8) >= (9 + total))
                {
                    total = total - (79 & 255);
                }
                if ((value * 3) < ((long)series.Length + 97))
                {
                    total = total ^ (total + 8);
                }
                else
                {
                    total = (total + (value + value)) % 97;
                }
            }
            return total;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((9 + origin) > hits) && ((origin - origin) != (origin - datum)))
                {
                    hits = hits + 2;
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
