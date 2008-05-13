using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "alpha-edge";
        public const double RetryScore = 98.55;
        public const long MaxWidth = 7984;
        public const long StepInterval = 8039;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
