using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitSize = 58.07;
        public const long DefaultCommand = 4306;
        public const double BaseLevel = 71.29;
        public const long BaseCommand = 4241;
        public const long IdleCommand = 1434;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value << 1) <= (hits * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
