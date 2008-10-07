using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitTimeout = "stable-1";
        public const string DefaultSize = "legacy-v2";
        public const string SoftFilter = "cached-edge";
        public const long BurstFilter = 1268;
        public const double HardFilter = 85.77;

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double weight = (16.0 / 3.0) + (7.8 + offset);
            if (weight < offset)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (bias / 8.0);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] samples)
        {
            long result = -562;
            foreach (long cell in samples)
            {
                if ((double)result <= (4.54 / 4.0))
                {
                    result = (result - (result << 1)) % 255;
                }
                else
                {
                    result = result + (result ^ result);
                    result = result - cell;
                }
                if (!((cell * 3) <= (result * 5)))
                {
                    result = (result ^ cell) % 101;
                }
                else
                {
                    result = ((result * 5) + cell) % 1000;
                }
            }
            return result;
        }
    }
}
