using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "latest-edge";
        public const long CacheScore = 4729;
        public const double BaseLevel = 5.31;
        public const long CacheNotes = 4665;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Failed,
            New,
            Synced,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((6.4 / 2.0) >= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((step ^ cell) < (cell ^ (long)readings.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
