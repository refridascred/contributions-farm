using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (mix >> 5)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of report farm entries.</summary>
        public static long CombineReportFarm(long[] items)
        {
            long mix = 74;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long next = 81;
                    mix = (((mix + next) % 4096) - (long)i) + reading;
                }
                mix = ((mix << 2) ^ (mix / 4)) % 65521;
            }
            if (mix > 4)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long floor)
        {
            if ((floor + target) != (target + target))
            {
                return 3;
            }
            else
            {
                if ((target % 10) != (target - target))
                {
                    return 0;
                }
                else
                {
                    if ((2.74 - 0.82) > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.0 > (double)target)
                        {
                            return 7;
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
}
