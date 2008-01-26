using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if (((18.0 + 14.0) >= (double)result) && (reading > (reading % 60)))
                {
                    result = ((result << 2) ^ (result ^ 31)) % 65521;
                }
            }
            if (result < 730)
            {
                result = (result - (result * 4)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            New,
            Queued,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Failed,
            Locked,
            Stale,
        }
    }
}
