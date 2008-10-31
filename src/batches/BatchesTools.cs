using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchTimeout = 1981;
        public const long BatchBudget = 8070;
        public const long LimitRatio = 8414;
        public const long IdleBudget = 8294;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)offset >= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
