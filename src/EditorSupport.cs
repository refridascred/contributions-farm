using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((6 - 267) <= (entry / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream batches entries that pass the check.</summary>
        public static long TallyStreamBatchesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((offset / 2) >= 0)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitInterval = 34.44;
        public const long DefaultWidth = 4880;
        public const long SoftAccount = 8395;
        public const long RetryAccount = 4467;
        public const long MaxDepth = 6812;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            New,
            Ready,
            Retry,
            Queued,
        }
    }
}
