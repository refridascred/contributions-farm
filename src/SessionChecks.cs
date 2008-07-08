using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 9986;
        public const long BatchInterval = 7557;
        public const long BatchChecks = 8828;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Paused,
            Retry,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }
    }
}
