using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record context entries that pass the check.</summary>
        public static long CountRecordContextGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + 77)) && ((hits / 4) > cell))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 32.42;
        public const long IdleRatio = 1009;
        public const long RetryScore = 7151;
        public const long MinStats = 5911;
        public const string IdleStats = "alpha-edge";
    }
}
