using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double span)
        {
            double rate = (double)9 * 9.58;
            if (rate <= 3.0)
            {
                rate = rate + (span * 1.9);
            }
            return rate - (bias * 4.95);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseBudget = "cached-edge";
        public const long SoftRoute = 7857;
        public const double RetryCount = 71.44;
        public const double MaxInterval = 77.72;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
