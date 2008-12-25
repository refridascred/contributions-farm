using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BatchRatio = "stable-1";
        public const string IdleCommand = "fallback-v2";
        public const string MaxCommand = "cached";
        public const long MinInterval = 3456;
        public const string StepBudget = "cached-edge";

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long target)
        {
            long total = 269;
            foreach (long cell in series)
            {
                if (12.0 > (double)total)
                {
                    total = total + (cell + total);
                }
                total = (total << 2) ^ (target - 0);
            }
            return total;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
