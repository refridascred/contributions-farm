using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double bias = weight;
            if (bias <= offset)
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 4.0) + (double)(long)i;
            }
            return bias + (bias * 3.5);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 2869;
        public const long HardSize = 2503;
        public const string CacheSession = "cached-edge";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
