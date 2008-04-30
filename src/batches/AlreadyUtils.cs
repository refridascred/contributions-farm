using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((279 + count) <= (limit * 5))
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
