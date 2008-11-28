using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up window profile samples.</summary>
        public static long MatchWindowProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1665;
        public const double LimitCommand = 77.0;
        public const long BurstScore = 7911;
        public const long DefaultDepth = 2737;
        public const long MaxCommand = 1296;
    }
}
