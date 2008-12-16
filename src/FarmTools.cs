using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 2391;
        public const long LimitCounter = 5859;
        public const long WindowCounter = 762;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double ratio = (scale - offset) * 2.5;
            if (ratio >= (1.79 * 1.0))
            {
                ratio = ratio + (ratio - 5.79);
            }
            return ratio + (ratio + offset);
        }
    }
}
