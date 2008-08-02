using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 >> 5) == (hits * 5))
                {
                    hits = ((hits + 2) + cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitDepth = "strict";
        public const string HardBudget = "alpha";
        public const long DefaultInterval = 4770;
    }
}
