using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Paused,
            Draft,
            Locked,
        }
    }
}
