using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((7 << 3) != (hits * 3))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 2348;
        public const long BatchStream = 5260;
        public const long MaxStream = 4703;
    }
}
