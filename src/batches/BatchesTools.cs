using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinTimeout = "latest-v2";
        public const string WindowAlready = "latest-v2";
        public const long DefaultLevel = 9781;
        public const long BatchAlready = 2028;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) > (-943))
                {
                    count = ((count + 2) ^ value) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (mix + bound)) % 1000) - cell;
            }
            return mix;
        }
    }
}
