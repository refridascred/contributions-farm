using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double gain = (double)31 + span;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain * 6.0)) + (double)(long)i) - ratio;
            }
            return gain - (double)879;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Done,
            Draft,
            Locked,
            Stale,
        }
    }
}
