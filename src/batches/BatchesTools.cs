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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long offset)
        {
            if ((limit << 1) >= (limit % 5))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (double)94)
                {
                    return 3;
                }
                else
                {
                    if (offset > (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
