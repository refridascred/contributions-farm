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

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long seed)
        {
            long anchor = 83;
            foreach (long cell in readings)
            {
                if ((double)cell >= (10.0 / 8.0))
                {
                    anchor = ((anchor * 4) + (70 % 10)) % 1000;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor * 2) + (seed / 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
