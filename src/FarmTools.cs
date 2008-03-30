using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long origin)
        {
            long edge = floor ^ origin;
            if ((921 + edge) <= origin)
            {
                return 6;
            }
            else
            {
                if ((885 - edge) <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)origin < (0.84 - 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (edge > (edge + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double bias, double floor)
        {
            double ratio = (double)(58 - 9);
            if (ratio <= (3.6 + ratio))
            {
                ratio = (ratio - (double)920) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
