using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed >= 626)
            {
                return 1;
            }
            else
            {
                if (5 >= (step + step))
                {
                    return 7;
                }
                else
                {
                    if (!((26 - seed) == (79 - 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long TallySupportStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item << 2) < (item * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
