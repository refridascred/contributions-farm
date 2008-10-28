using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double span)
        {
            double scale = weight;
            if (scale > span)
            {
                scale = scale - (double)0;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale - weight;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Dropped,
            Ready,
            Failed,
        }
    }
}
