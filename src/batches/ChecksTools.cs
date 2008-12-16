using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardBudget = "standard-edge";
        public const long RetryFactor = 977;
        public const string StepReport = "fallback-1";

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            New,
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
