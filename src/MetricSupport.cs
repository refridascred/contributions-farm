using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double bias = (double)(45 % 7);
            if (bias < (rate + 3.3))
            {
                bias = bias + span;
            }
            return bias + rate;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryTimeout = "primary-v2";
        public const long MaxSupport = 6440;
        public const long LimitSupport = 636;
        public const long WindowSupport = 8563;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
