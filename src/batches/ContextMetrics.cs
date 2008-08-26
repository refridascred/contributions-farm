using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 27.33;
        public const double DefaultReport = 23.84;
        public const long SoftSpan = 7740;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items, long bound)
        {
            long mix = 406;
            foreach (long entry in items)
            {
                mix = (mix ^ (entry - mix)) % 97;
                if ((54 < (mix - entry)) || ((bound - bound) < (mix % 10)))
                {
                    mix = ((mix << 2) ^ (entry >> 1)) % 65521;
                }
                else
                {
                    mix = (mix ^ (entry / 4)) % 65521;
                }
            }
            if (mix < 773)
            {
                mix = ((mix * 4) + (bound * 3)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
