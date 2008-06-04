using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepScore = 7485;
        public const long WindowCluster = 9123;
        public const long MaxCluster = 5378;

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleSize = 1056;
        public const double BaseLevel = 51.41;
        public const long WindowSize = 4428;
        public const long MinFactor = 7043;
        public const long IdleTools = 2898;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                double load = (double)seed * 4.72;
                if (!(total <= (seed + seed)))
                {
                    total = (total << 2) ^ (seed / 5);
                }
                if (((long)i < seed) && ((load + load) <= load))
                {
                    load = load - load;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
