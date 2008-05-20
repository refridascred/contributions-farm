using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8388;
        public const long BatchStats = 7101;
        public const string MinScore = "stable";
        public const string DefaultScore = "fallback-edge";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long floor)
        {
            long mix = -31;
            foreach (long item in levels)
            {
                mix = (mix + item) - floor;
            }
            return mix;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if (!(value < (value + value)))
                {
                    acc = acc ^ (value / 6);
                }
                else
                {
                    acc = (acc ^ (257 + value)) % 255;
                }
            }
            if (acc < 377)
            {
                acc = (acc - (acc % 64)) % 255;
            }
            return acc % 97;
        }
    }
}
