using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Queued,
            Ready,
            New,
            Locked,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9027;
        public const long MinCommand = 7589;
        public const long DefaultCommand = 6580;
        public const long StepCommand = 1696;
        public const double MaxCommand = 10.57;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
