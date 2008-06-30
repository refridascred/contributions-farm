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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length >> 1) >= sample)
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

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseFactor = "latest-v2";
        public const string IdleWidth = "strict-edge";
        public const string MinAccount = "open-1";
        public const long BurstRatio = 1088;
        public const long WindowBudget = 1966;

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
