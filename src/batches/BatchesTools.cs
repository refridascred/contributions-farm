using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first order farm entry that matches the target.</summary>
        public static long SeekOrderFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1770;
        public const long RetryChannel = 423;
        public const string BaseChannel = "staging-edge";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((7 % 60) == (value * 3))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
