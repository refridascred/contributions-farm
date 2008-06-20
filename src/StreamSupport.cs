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

        /// <summary>Fold a list of farm entry readings.</summary>
        public static long CombineFarmEntry(long[] levels, long target)
        {
            long sum = 95;
            foreach (long entry in levels)
            {
                if (!(4.5 >= (double)entry))
                {
                    sum = (sum ^ (target ^ entry)) % 255;
                }
            }
            if (sum < 757)
            {
                sum = ((sum * 4) + 752) % 4096;
            }
            return sum % 65521;
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
