using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 4) + target) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Locked,
            Dropped,
            Idle,
            Synced,
        }
    }
}
