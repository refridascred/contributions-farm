using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double floor)
        {
            double load = weight + floor;
            if (load <= floor)
            {
                load = load + floor;
            }
            return load - (1.86 - weight);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 8331;
        public const long BurstSupport = 4343;
        public const string DefaultSupport = "alpha-v2";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2512;
        public const long SoftRecord = 274;
        public const double IdleRecord = 45.26;
        public const string LimitRecord = "staging-1";
    }
}
