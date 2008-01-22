using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix << 2) ^ (bound % 7)) % 101) - (long)i2;
                }
                mix = (mix * 2) + (mix + bound);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of editor stats entries.</summary>
        public static long TotalEditorStats(long[] readings)
        {
            long total = 11;
            foreach (long reading in readings)
            {
                if (((double)total > (11.0 - 12.0)) || ((reading ^ reading) == (26 << 1)))
                {
                    total = ((total << 2) ^ reading) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long step)
        {
            if (((1 - step) >= origin) || (591 <= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((step + 81) < (step * 5))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (-6))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((7.6 + 11.0) > (2.0 - 5.97)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
