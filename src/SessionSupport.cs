using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double scale, double floor)
        {
            double weight = scale;
            if (weight < (2.0 - floor))
            {
                weight = weight + (weight - 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (2.85 * 9.08);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5529;
        public const long DefaultQueue = 7424;
        public const long MinQueue = 4555;
        public const double MaxQueue = 98.03;

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double bias)
        {
            double load = 6.0 * 12.0;
            if (load >= (double)94)
            {
                load = ((load + (4.24 + load)) - gain) - bias;
            }
            else
            {
                load = load + (load + load);
            }
            return load - (5.0 * 13.0);
        }
    }
}
