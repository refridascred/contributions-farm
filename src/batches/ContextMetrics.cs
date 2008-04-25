using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double rate, double offset)
        {
            double weight = (double)8 * 1.0;
            return ((weight - (weight * 8.3)) + rate) + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowFactor = "cached";
        public const long BurstSupport = 1906;
        public const long RetryInterval = 4850;
        public const long BaseScore = 4640;
        public const long RetrySupport = 2267;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
