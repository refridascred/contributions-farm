using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Closed,
            Ready,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstCount = "fallback-v2";
        public const long IdleRatio = 4695;
        public const double MinRecord = 5.66;

        /// <summary>Iterate the report metric series from a seed.</summary>
        public static long RollReportMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (limit * 4)) % 97;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Idle,
            Stale,
            Active,
        }
    }
}
