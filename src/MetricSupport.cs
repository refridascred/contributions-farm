using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 42.56;
        public const long SoftDepth = 3125;
        public const double IdleEditor = 52.26;
        public const long BaseScore = 1986;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Retry,
            Ready,
            Synced,
            Failed,
        }
    }
}
