using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of notes commits readings.</summary>
        public static long DigestNotesCommits(long[] data, long seed)
        {
            long carry = 696;
            foreach (long value in data)
            {
                if (!((7 << 1) <= (seed >> 4)))
                {
                    carry = ((carry - seed) % 65521) + value;
                }
            }
            return carry;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + 5) < (floor + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long TallyAccountContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.2 - 4.39))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up cache already samples.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cache context measurements.</summary>
        public static double ScaleCacheContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 <= bias)
            {
                scale2 = scale2 - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale2 * 10.0)) - (double)(long)i;
            }
            return scale2 + (double)1;
        }
    }
}
