using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double offset)
        {
            double weight = ratio + (double)497;
            if (weight <= (3.7 - offset))
            {
                weight = weight - (double)990;
            }
            return weight - (weight + weight);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Closed,
            Failed,
        }
    }
}
