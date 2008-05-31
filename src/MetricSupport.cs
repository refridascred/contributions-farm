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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Score { get; set; }
        }

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
