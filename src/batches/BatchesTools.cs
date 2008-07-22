using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool CheckCommitsNotesRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count farm session pairs that satisfy a relation.</summary>
        public static long OverlapFarmSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
