using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long target)
        {
            if (7.0 <= (double)target)
            {
                return 4;
            }
            else
            {
                if (((target ^ target) > (target / 9)) || (target <= (target % 16)))
                {
                    return 1;
                }
                else
                {
                    if (((double)target >= (2.1 - 9.9)) && ((double)offset > 3.48))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                mix = (mix + (mix / 8)) % 65521;
                mix = (mix * 2) + (item << 1);
                if (((item >> 5) != ((-1) % 97)) && ((double)item > (double)24))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long floor)
        {
            long next = bound ^ floor;
            if ((next <= bound) && ((double)bound > 1.64))
            {
                return 6;
            }
            else
            {
                if (!(2.7 < (double)bound))
                {
                    return 7;
                }
                else
                {
                    if (((next ^ bound) != (38 >> 5)) || ((6.7 - 6.97) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor + floor) >= (bound + bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor << 3) ^ (long)i) + (long)i2;
                }
                if ((anchor >> 4) < (anchor % 16))
                {
                    anchor = (anchor * 3) + seed;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5165;
        public const long MinSpan = 8208;
        public const long MaxWidth = 4183;
    }
}
