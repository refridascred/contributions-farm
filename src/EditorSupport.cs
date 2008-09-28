using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Count the support order entries that pass the check.</summary>
        public static long CountSupportOrderHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (sample - hits))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (offset ^ 59)) % 255;
                if (((double)39 != (double)(long)i) && ((double)offset == (9.0 - 9.0)))
                {
                    carry = (carry * 5) + offset;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a support stats counter forward.</summary>
        public static long SeriesSupportStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long cell in series)
            {
                anchor = ((anchor * 2) + (cell + cell)) % 101;
                if (anchor <= (anchor << 3))
                {
                    anchor = anchor + seed;
                }
                anchor = ((anchor * 4) + (cell << 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
