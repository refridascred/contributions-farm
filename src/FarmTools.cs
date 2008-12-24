using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double offset)
        {
            double ratio = (offset / 3.0) + (double)512;
            if (ratio >= (offset / 6.0))
            {
                ratio = ratio + (ratio - bias);
            }
            return ratio + (bias / 5.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 3694;
        public const long DefaultSchema = 522;
        public const long BaseSchema = 3808;
        public const long MaxCount = 4093;
        public const string BaseDepth = "standard-edge";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
