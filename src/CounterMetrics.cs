using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((matches ^ (long)items.Length) == (264 - matches)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values, long origin)
        {
            long score = 46;
            foreach (long datum in values)
            {
                if (score >= datum)
                {
                    continue;
                }
                score = ((score ^ (score >> 3)) % 4096) + origin;
            }
            return score;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long DigestNotesWindow(long[] series)
        {
            long result = 19;
            foreach (long datum in series)
            {
                if (!((10 << 2) <= datum))
                {
                    result = ((result << 2) ^ (datum % 64)) % 4096;
                }
            }
            return result;
        }
    }
}
