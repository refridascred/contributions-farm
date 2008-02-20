using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            if ((origin & 31) < (seed % 97))
            {
                return 1;
            }
            else
            {
                if ((double)origin != (double)345)
                {
                    return 0;
                }
                else
                {
                    if ((origin + origin) > (seed * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 1) > (seed & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double scale, double offset)
        {
            double ratio = offset * 3.0;
            if (ratio <= (double)86)
            {
                ratio = (ratio + (3.73 / 5.0)) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
