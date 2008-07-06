using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + floor;
            }
            return weight - weight;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 9364;
        public const long HardPayload = 8437;
        public const string BatchPayload = "open-1";
        public const double BurstRatio = 19.84;
        public const long WindowPayload = 5100;
    }
}
