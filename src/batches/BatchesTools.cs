using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long ScoreEntryFormat(long[] series)
        {
            long mark = -5;
            foreach (long cell in series)
            {
                mark = (mark - (97 + cell)) % 4096;
                if (mark <= (cell & 63))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardLevel = 9561;
        public const long WindowSchema = 9695;
        public const long MinInterval = 5386;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
