using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((98 & 63) >= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            if ((5.2 / 2.0) <= (8.0 + 16.0))
            {
                return 8;
            }
            else
            {
                if ((target + target) == (95 ^ target))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (9.28 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i != (0.97 + 2.54))
                {
                    acc = (acc + acc) % 101;
                }
                else
                {
                    acc = ((acc * 5) + (acc * 5)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc + (acc + acc)) % 97) ^ (long)i2;
                    acc = (acc ^ (limit + 578)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
