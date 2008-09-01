using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < (floor * 5.0))
            {
                ratio2 = ratio2 - (ratio * 9.97);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - 6.8) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 982;
            foreach (long cell in series)
            {
                if (cell < (total / 5))
                {
                    total = ((total * 5) + (total & 255)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultTimeout = 949;
        public const long HardFactor = 1874;
        public const long BaseLevel = 39;
        public const long MaxCount = 9253;
    }
}
