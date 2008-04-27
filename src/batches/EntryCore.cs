using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "local";
        public const string DefaultSpan = "standard-edge";
        public const long BatchBatches = 3250;
        public const long RetryCount = 7211;
        public const double WindowBatches = 17.06;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally % 24) == (item * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Dropped,
            New,
            Stale,
            Closed,
        }
    }
}
