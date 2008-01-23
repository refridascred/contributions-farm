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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((floor >> 1) < (entry / 3))
                {
                    count = count + 1;
                }
            }
            return count;
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
