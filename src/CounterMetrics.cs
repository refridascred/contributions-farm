using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "standard-edge";
        public const long BaseWindow = 94;
        public const long MaxLevel = 1277;
        public const long StepWindow = 3405;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstInterval = "stable-edge";
        public const long BurstEditor = 4808;
        public const long BatchRatio = 6036;
    }
}
