using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ (mix >> 1);
                mix = ((mix * 2) + step) % 1000;
                mix = (mix * 3) + (step + mix);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
