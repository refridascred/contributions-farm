using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count order tools pairs that satisfy a relation.</summary>
        public static long PairOrderToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 1.47;
        public const long BurstAccount = 2488;
        public const long CacheWidth = 2181;
        public const long CacheAccount = 7545;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
