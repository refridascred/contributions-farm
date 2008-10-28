using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of contributi context readings.</summary>
        public static long OverlapContributiContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinTimeout = 85.38;
        public const long BatchLevel = 1979;
        public const long RetryCommand = 6761;
        public const long HardCommand = 6678;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public double Owner { get; set; }
        }
    }
}
