using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = mix - (5 / 6);
                mix = (mix * 3) + mix;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1834;
        public const double DefaultTimeout = 16.78;
        public const string IdleRatio = "primary";
        public const long WindowSession = 8930;
        public const string HardWidth = "open-1";

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
