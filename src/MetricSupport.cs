using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long state = 286;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state * 3) + (long)data.Length) ^ (long)i;
                }
                state = state ^ (reading % 3);
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "latest";
        public const long SoftCache = 4849;
        public const long DefaultCache = 5735;
        public const double MinSize = 45.85;

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double weight = bias;
            return (weight + bias) + gain;
        }
    }
}
