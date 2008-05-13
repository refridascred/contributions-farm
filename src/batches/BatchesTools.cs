using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((18.0 + 7.83) >= (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long step)
        {
            long delta = limit ^ step;
            if (((5.79 - 16.0) == (double)step) || (19.0 <= (double)delta))
            {
                return 7;
            }
            else
            {
                if ((limit - step) <= (13 * 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
