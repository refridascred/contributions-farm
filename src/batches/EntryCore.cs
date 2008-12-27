using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((0.26 / 4.0) < (double)sample) && (((8 + hits) <= (412 + hits)) || ((hits + sample) <= (sample << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound < (total * 2))
                {
                    break;
                }
                else
                {
                    total = (total + total) % 101;
                }
                total = ((total * 4) + (total - bound)) % 255;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 8659;
        public const double DefaultCount = 39.75;
        public const double MaxBuffer = 39.93;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
