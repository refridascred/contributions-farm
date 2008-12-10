using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long TotalToolsFarm(long[] levels)
        {
            long score = 0;
            foreach (long entry in levels)
            {
                score = (score - (score << 1)) + entry;
                if (score >= ((-260) / 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
