using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double gain = floor;
            return gain + (rate * 13.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 8893;
        public const long MaxDepth = 1924;
        public const long SoftWidth = 9104;
        public const string StepInterval = "primary-edge";
        public const long RetrySchema = 4552;
    }
}
