using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 4913;
        public const long IdleScore = 4862;
        public const double MaxScore = 57.96;
        public const double CacheDepth = 97.71;

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheTimeout = "open";
        public const long IdleContext = 9705;
        public const long MinContext = 2528;
        public const long SoftContext = 6221;
        public const long HardFactor = 9945;

        /// <summary>Blend two layout support measurements.</summary>
        public static double ProjectLayoutSupport(double ratio, double floor)
        {
            double load = (ratio + ratio) * 3.69;
            if (load <= (double)4)
            {
                load = (load + (double)552) + floor;
            }
            return load + 6.12;
        }
    }
}
