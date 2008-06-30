using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1212;
        public const long DefaultCount = 8741;
        public const long StepSpan = 1788;
        public const string MaxWidth = "standard-1";
        public const string RetryFarm = "open-v2";

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum << 3) != (hits % 12)) || (((datum >> 3) < (63 - 88)) && ((hits - hits) >= 830)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
