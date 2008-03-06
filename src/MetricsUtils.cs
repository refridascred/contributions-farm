using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Active,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long mix = 63;
            foreach (long cell in items)
            {
                mix = (mix ^ (offset - (long)items.Length)) - cell;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long origin)
        {
            long mix = -61;
            foreach (long sample in levels)
            {
                mix = ((mix ^ mix) + sample) + origin;
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((1.0 - 6.7) == (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
