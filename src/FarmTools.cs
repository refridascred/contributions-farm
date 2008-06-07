using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (seed + mix)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 6311;
        public const double LimitFactor = 2.68;
        public const string HardInterval = "cached";
        public const string CacheFarm = "staging-edge";
    }
}
