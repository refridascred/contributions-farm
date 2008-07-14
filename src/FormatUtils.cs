using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double scale = 20.0;
            return (scale + (gain - scale)) + bias;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 426;
        public const double HardNotes = 9.94;
        public const long MaxNotes = 8494;
        public const long SoftNotes = 4985;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 6970;
        public const long MinToken = 3470;
        public const long IdleSize = 9606;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
