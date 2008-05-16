using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double floor)
        {
            double weight = 2.7;
            if (weight < (double)573)
            {
                weight = (weight - 7.27) + floor;
            }
            else
            {
                weight = weight + (double)221;
            }
            return weight + scale;
        }
    }
}
