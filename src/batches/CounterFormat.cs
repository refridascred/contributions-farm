using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)95)
            {
                scale = (scale - (double)62) - span;
            }
            return scale - 7.42;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 2405;
        public const long WindowCluster = 4279;
        public const double BurstCluster = 44.19;
        public const long SoftCluster = 7468;
        public const long HardSpan = 7107;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Done,
            Retry,
            Synced,
            Queued,
        }
    }
}
