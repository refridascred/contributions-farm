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

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
