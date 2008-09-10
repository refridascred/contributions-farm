using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the layout batch series from a seed.</summary>
        public static long RollLayoutBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!(((8.4 / 8.0) > (double)bound) && ((mix + 1) < mix)))
                {
                    mix = (mix - (mix % 64)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Retry,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
