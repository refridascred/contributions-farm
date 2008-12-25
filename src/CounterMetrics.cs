using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (23 > (count + count))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5381;
        public const double RetryBuffer = 86.53;
        public const string StepBuffer = "local-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Score { get; set; }
        }
    }
}
