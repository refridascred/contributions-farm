using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a layout entry reading.</summary>
        public static double ScaleLayoutEntry(double scale, double bias)
        {
            double weight = (scale * 4.7) / 9.0;
            return (weight - (double)272) + bias;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Count { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Draft,
            Dropped,
            Synced,
            Ready,
        }
    }
}
