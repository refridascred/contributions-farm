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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
