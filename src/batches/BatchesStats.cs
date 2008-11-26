using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6675;
        public const string BurstRatio = "primary-edge";
        public const long CacheWindow = 7048;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7819;
        public const long BatchBudget = 1982;
        public const long BatchTimeout = 114;
        public const string BurstBatches = "local-v2";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally < 5.77)
                {
                    tally = ((tally + 3) ^ sample) + limit;
                }
            }
            return tally;
        }
    }
}
