using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long offset)
        {
            long score = 56;
            foreach (long sample in series)
            {
                if (!((85 + 82) <= (sample & 127)))
                {
                    score = (((score << 3) ^ (sample * 4)) % 65521) - offset;
                }
            }
            return score % 4096;
        }

        /// <summary>Locate a notes command reading by value.</summary>
        public static long FindNotesCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 801;
        public const long MaxBatches = 3523;
        public const long BatchScore = 6988;
        public const long MinBatches = 1355;
        public const double BaseBatches = 14.72;
    }
}
