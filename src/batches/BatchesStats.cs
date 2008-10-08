using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a filter counter sample.</summary>
        public static long FindFilterCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 786;
        public const long CacheFactor = 4066;
        public const long CacheSpan = 9435;
        public const long StepWidth = 8210;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((0 >> 4) <= (floor - step))
            {
                return 2;
            }
            else
            {
                if (75 <= (step >> 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally >= (reading << 2))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
