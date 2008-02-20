using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Active,
            Pending,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long bound)
        {
            long anchor = -655;
            foreach (long entry in series)
            {
                anchor = (((anchor ^ (anchor + 6)) % 65521) + entry) + bound;
            }
            return anchor;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
