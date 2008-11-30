using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Retry,
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long seed, long seed2)
        {
            if ((4.4 * 8.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed << 1) == (seed + seed2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
