using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5567;
        public const long BatchBudget = 2756;
        public const long BatchRoute = 379;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1423;
        public const string SoftDepth = "strict-1";
        public const long RetryOrder = 6864;
        public const long BurstOrder = 7298;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstWidth = 52.36;
        public const long RetryRatio = 3769;
        public const double IdleBudget = 10.91;
        public const long BurstInterval = 4458;
        public const long IdleTools = 75;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!(seen > seed))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
