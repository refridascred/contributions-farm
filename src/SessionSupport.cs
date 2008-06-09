using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double scale = rate;
            if (scale >= rate)
            {
                scale = (scale + (double)41) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 5980;
        public const long HardRatio = 3367;
        public const string StepTimeout = "fallback-v2";
        public const string BurstOrder = "staging";
        public const long MaxScore = 4962;

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((double)target < (double)origin)
            {
                return 5;
            }
            else
            {
                if ((6.0 + 9.5) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((124 + origin) > (origin * 5))
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
}
