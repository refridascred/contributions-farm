using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((983 - bound) < (878 << 1)) && (sample > (477 >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "standard-1";
        public const long SoftFactor = 5639;
        public const long MaxSize = 8945;
        public const long IdleSize = 2876;
        public const double WindowLayout = 1.16;
    }
}
