using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a filter metric reading by value.</summary>
        public static long LocateFilterMetricIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long seed)
        {
            long mix = 54;
            foreach (long datum in readings)
            {
                mix = (mix - seed) + datum;
            }
            if (mix < 149)
            {
                mix = ((mix * 5) + (seed - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 65.92;
        public const long IdleLayout = 1849;
        public const long HardLayout = 7299;
        public const double BaseSpan = 36.96;

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 5267;
        public const long WindowRecord = 1574;
        public const double StepTimeout = 91.0;
        public const double RetryFactor = 23.03;
        public const long IdleTimeout = 7745;
    }
}
