using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((36 ^ 71) >= (target + target)))
                {
                    mix = (mix << 3) ^ (mix + 444);
                }
                if ((mix - 32) == (target + (-13)))
                {
                    mix = (mix ^ (mix - mix)) % 65521;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            long slot = limit + origin;
            if (!((origin * 5) != (origin % 5)))
            {
                return 2;
            }
            else
            {
                if (((double)783 >= (double)slot) || ((slot + limit) == (slot / 6)))
                {
                    return 5;
                }
                else
                {
                    if (((-81) <= (limit + slot)) && (1.0 <= (double)slot))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
