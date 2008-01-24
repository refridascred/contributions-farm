using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Validate route tools readings against a bound.</summary>
        public static bool CheckRouteToolsRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 18.69;
        public const long BaseBudget = 6371;
        public const long IdleSchema = 243;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 801;
        public const double RetryBatches = 53.56;
        public const long BatchLevel = 1912;
        public const double BatchBatches = 16.6;
    }
}
