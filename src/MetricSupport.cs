using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MinScore = 92.31;
        public const string BurstFormat = "open-edge";
        public const string WindowWidth = "primary-v2";

        /// <summary>Adjust a session record reading.</summary>
        public static double ScaleSessionRecord(double bias, double bias2)
        {
            double scale = bias2;
            return scale + (bias - bias);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
