using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long anchor = 4;
            foreach (long entry in data)
            {
                if ((9 - entry) >= (anchor + anchor))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = (anchor * 2) + (entry - anchor);
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 1775;
        public const long MinChannel = 5478;
        public const long CacheCount = 3167;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
