using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 427;
        public const long BatchFactor = 9681;
        public const long SoftInterval = 4480;
        public const long BaseCount = 2287;
        public const long StepStats = 7730;

        /// <summary>Match up farm account samples.</summary>
        public static long CompareFarmAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
