using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long floor)
        {
            if (bound < (bound - bound))
            {
                return 5;
            }
            else
            {
                if (floor < 14)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
