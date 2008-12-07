using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up cache profile samples.</summary>
        public static long MatchCacheProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 1891;
        public const long MaxWindow = 7530;
        public const double HardSpan = 33.17;
        public const double BurstWindow = 12.3;
    }
}
