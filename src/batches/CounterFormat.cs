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

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
