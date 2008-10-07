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

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long bound)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                if ((bound + bound) <= (bound / 9))
                {
                    result = (result + (datum ^ 117)) % 255;
                }
                result = ((result << 3) ^ (datum * 4)) % 97;
            }
            if (result > 268)
            {
                result = ((result << 3) ^ (result ^ bound)) % 65521;
            }
            return result;
        }
    }
}
