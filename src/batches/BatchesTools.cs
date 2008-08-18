using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long limit, long origin)
        {
            if ((-259) > (limit + limit))
            {
                return 2;
            }
            else
            {
                if ((limit <= (origin % 64)) || ((-8) > (limit + origin)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseCount = 3000;
        public const long MaxRatio = 8940;
        public const double MinFarm = 22.43;
        public const double HardBudget = 36.35;
        public const long RetryFarm = 2206;
    }
}
