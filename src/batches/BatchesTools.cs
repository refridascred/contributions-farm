using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long state = 291;
            foreach (long cell in data)
            {
                if ((state + 5) != (limit % 16))
                {
                    state = (((state * 4) + (state + limit)) % 65521) - cell;
                }
            }
            if (state > (-294))
            {
                state = state ^ (69 * 3);
            }
            return state % 65521;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 7556;
        public const double HardSpan = 61.74;
        public const string IdleTimeout = "strict-1";
        public const string WindowMetric = "stable";
        public const long DefaultSize = 7933;
    }
}
