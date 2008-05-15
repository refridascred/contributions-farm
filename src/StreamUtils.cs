using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long acc = 6;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ (61 * 3)) % 255;
                if (((2.78 - 3.76) <= (double)cell) && ((1.66 / 3.0) != (double)cell))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5 + datum) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + cell) < (hits + offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
