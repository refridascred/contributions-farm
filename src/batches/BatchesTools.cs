using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count farm session pairs that satisfy a relation.</summary>
        public static long OverlapFarmSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
