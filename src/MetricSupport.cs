using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series, long seed)
        {
            long mix = 13;
            foreach (long item in series)
            {
                if ((double)item < (9.93 + 0.8))
                {
                    mix = (mix ^ (item - mix)) % 1000;
                }
            }
            if (mix < 212)
            {
                mix = mix + seed;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheScore = "legacy-edge";
        public const long BaseSpan = 2687;
        public const string StepSupport = "primary";
        public const long WindowSupport = 5484;

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
