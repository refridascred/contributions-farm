using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + (seed & 1)) % 255;
                total = ((total << 3) ^ (long)i) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long seed)
        {
            if ((seed / 4) >= (622 & 15))
            {
                return 4;
            }
            else
            {
                if ((21 * 3) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((seed - 80) == ((-232) + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
