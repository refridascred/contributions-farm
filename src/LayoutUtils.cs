using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double drift = gain / 5.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)363) + (double)(long)i) + offset;
            }
            return drift - (drift - 6.2);
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long origin)
        {
            if ((double)bound <= (4.26 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 4.02)
                {
                    return 4;
                }
                else
                {
                    if (origin >= (origin * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((650 + origin) < (3 + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long diff = step - seed;
            if ((364 << 2) <= seed)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (85 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((diff & 7) <= (diff * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
