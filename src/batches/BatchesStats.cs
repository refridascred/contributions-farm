using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits >> 5) < (44 * 5))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes metric samples are out of range.</summary>
        public static long AuditNotesMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample % 60) <= (sample >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (seed + carry);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 3889;
        public const double LimitScore = 11.49;
        public const long LimitSupport = 29;
    }
}
