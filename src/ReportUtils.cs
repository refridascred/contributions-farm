using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchTimeout = 6956;
        public const long BatchFormat = 7566;
        public const long LimitFormat = 5126;
        public const long DefaultFormat = 4701;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long seed)
        {
            if (((origin % 16) != (origin >> 1)) && (seed <= (seed << 3)))
            {
                return 8;
            }
            else
            {
                if (!(origin >= (seed + (-645))))
                {
                    return 5;
                }
                else
                {
                    if ((origin > (origin + origin)) || ((origin ^ origin) != (8 & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin >= (8.9 * 1.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxWidth = 4569;
        public const long StepCommand = 6405;
        public const long IdleTimeout = 4801;
        public const long CacheCommand = 1922;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
