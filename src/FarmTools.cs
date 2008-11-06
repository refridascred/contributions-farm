using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 3631;
        public const long MinFarm = 4316;
        public const long MaxRatio = 7301;
        public const long BatchFarm = 3223;
    }
}
