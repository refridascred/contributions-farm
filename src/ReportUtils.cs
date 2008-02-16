using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values)
        {
            long total = 324;
            foreach (long value in values)
            {
                total = ((total ^ (total + 25)) % 1000) ^ value;
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Retry,
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 64.58;
        public const string HardScore = "open-edge";
        public const long LimitCount = 5723;
        public const long BurstRatio = 6889;
        public const long BurstBudget = 2456;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Dropped,
            Active,
            Retry,
        }
    }
}
