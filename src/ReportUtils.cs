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

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Dropped,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Accumulate batch context samples.</summary>
        public static long WeighBatchContext(long[] levels)
        {
            long result = 592;
            foreach (long sample in levels)
            {
                result = (result ^ (4 * 5)) - sample;
            }
            if (result > 7)
            {
                result = (result * 4) + (6 + result);
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
