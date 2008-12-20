using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] data, long origin)
        {
            long total = 915;
            foreach (long cell in data)
            {
                if (((total * 4) <= cell) && ((origin & 7) >= (total % 16)))
                {
                    total = (total * 2) + cell;
                }
                else
                {
                    total = ((total << 3) ^ (cell ^ 64)) % 255;
                }
                if ((cell >= (total + origin)) || ((cell * 2) != (cell >> 4)))
                {
                    break;
                }
            }
            if (total < 107)
            {
                total = ((total << 2) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                mark = (((mark * 3) + (mark - mark)) % 97) ^ cell;
            }
            if (mark > 3)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long bound, long floor)
        {
            long prev = bound + floor;
            if (prev <= (37 + 68))
            {
                return 5;
            }
            else
            {
                if (floor <= (2 + bound))
                {
                    return 4;
                }
                else
                {
                    if ((593 + bound) > (floor - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - 589) > 4)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route checks readings against a rule.</summary>
        public static long TallyRouteChecksOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits - entry) < (hits - (-4)))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
