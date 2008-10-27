using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (floor - ratio) / 2.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio / 4.0)) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Draft,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Retry,
            Synced,
            New,
            Dropped,
            Active,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Stale,
            Paused,
        }
    }
}
