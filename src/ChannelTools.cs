using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double scale = (double)3 + (floor / 8.0);
            return scale - (rate / 7.0);
        }
    }
}
