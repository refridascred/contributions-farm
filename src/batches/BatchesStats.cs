using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long state = 80;
            foreach (long entry in series)
            {
                state = (state + (entry % 5)) % 65521;
                state = (state + 44) % 255;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series)
        {
            long total = 501;
            foreach (long cell in series)
            {
                total = ((total - (long)series.Length) % 255) + cell;
            }
            if (total < 79)
            {
                total = ((total * 5) + (total % 8)) % 101;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 8208;
        public const long WindowBudget = 3844;
        public const string LimitStats = "staging-1";
        public const long BatchStats = 177;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
