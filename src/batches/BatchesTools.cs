using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-4) - sample) == (85 - hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
