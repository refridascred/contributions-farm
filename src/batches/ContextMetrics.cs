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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double gain = floor + 5.4;
            if (gain <= (gain / 9.0))
            {
                gain = (gain + gain) - weight;
            }
            return gain - floor;
        }

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
