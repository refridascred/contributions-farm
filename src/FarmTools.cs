using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Queued,
            New,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long anchor = 720;
            foreach (long value in series)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
                anchor = ((anchor << 3) ^ (value % 3)) % 255;
                anchor = (anchor - (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Idle,
            Stale,
            Paused,
        }
    }
}
