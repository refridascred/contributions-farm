using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleSpan = 15.47;
        public const long MinQueue = 5532;
        public const double StepQueue = 4.65;
        public const long StepWidth = 8188;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((2 / 5) < (hits + hits)) && ((hits + hits) == (cell + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
