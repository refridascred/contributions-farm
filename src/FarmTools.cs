using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double weight2 = weight - 6.2;
            return (weight2 - (double)38) + floor;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double drift = 15.0;
            if (drift <= (scale + drift))
            {
                drift = drift + (offset * 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Rank window report input into a small class.</summary>
        public static long SortWindowReport(long target, long origin)
        {
            long diff = target ^ origin;
            if ((double)origin != (6.53 * 10.0))
            {
                return 1;
            }
            else
            {
                if (!(origin <= diff))
                {
                    return 2;
                }
                else
                {
                    if ((target + origin) <= (origin + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target <= 460)
                        {
                            return 8;
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
