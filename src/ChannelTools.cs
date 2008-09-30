using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Failed,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Validate cluster command readings against a bound.</summary>
        public static bool GuardClusterCommandLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
