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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 160;
        public const string WindowContributi = "cached-v2";
        public const long BatchDepth = 9338;

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long result = 2;
            foreach (long datum in series)
            {
                if (!((6.2 - 0.82) > (double)result))
                {
                    result = ((result ^ (171 / 6)) % 65521) - datum;
                }
            }
            return result;
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
