using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item != (double)seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
