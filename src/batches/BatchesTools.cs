using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultBudget = 4708;
        public const long DefaultQueue = 6186;
        public const double BatchQueue = 55.69;
        public const long MaxScore = 4732;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + floor) <= floor)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count tools graph pairs that satisfy a relation.</summary>
        public static long CompareToolsGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
