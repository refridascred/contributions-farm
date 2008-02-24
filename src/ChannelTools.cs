using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long floor, long seed)
        {
            long delta = floor + seed;
            if (delta <= (seed * 4))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 - seed))
                {
                    return 3;
                }
                else
                {
                    if (7 > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3813;
        public const long BatchTimeout = 2381;
        public const string BatchNotes = "open-edge";
    }
}
