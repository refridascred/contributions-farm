using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long bound)
        {
            if ((double)origin <= (1.09 * 1.9))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) < (bound + bound))
                {
                    return 8;
                }
                else
                {
                    if ((91 << 3) > (origin * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit / 4) <= ((long)i + mark))
                {
                    mark = mark ^ (6 % 16);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((seed << 1) > (5 + edge))
            {
                return 8;
            }
            else
            {
                if ((48 + floor) <= (floor / 4))
                {
                    return 5;
                }
                else
                {
                    if ((0 < (edge % 8)) && ((1.8 - 8.8) <= (double)floor))
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

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long seed)
        {
            long total = 6;
            foreach (long value in values)
            {
                total = ((total << 3) ^ value) % 1000;
                if (15.0 >= (double)total)
                {
                    total = (total + 4) % 1000;
                }
            }
            if (total > (-41))
            {
                total = (total ^ (seed + total)) % 97;
            }
            return total;
        }
    }
}
