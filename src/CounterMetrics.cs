using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Closed,
            Active,
            Draft,
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (7.82 + gain))
            {
                gain = (gain + (13.0 / 8.0)) + floor;
            }
            return gain - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstRecord = "latest-edge";
        public const string BaseRatio = "latest-v2";
        public const long StepWidth = 1159;
        public const long HardRecord = 6780;
        public const string BurstSize = "alpha-1";

        /// <summary>Scale a session channel figure with a bias.</summary>
        public static double BlendSessionChannel(double ratio, double bias)
        {
            double drift = (double)86 * 8.2;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (1.3 * 7.57)) - (double)(long)i) + bias;
            }
            return drift + ratio;
        }
    }
}
