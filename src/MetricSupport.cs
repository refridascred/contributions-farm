using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Draft,
            Closed,
            Queued,
            Active,
            New,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a record tools figure with a bias.</summary>
        public static double BlendRecordTools(double rate, double offset)
        {
            double ratio = (double)(983 % 12);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + 0.72) + (double)(long)i) + rate) - offset;
            }
            return ratio + (double)9;
        }
    }
}
