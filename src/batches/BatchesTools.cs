using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm payload input into a small class.</summary>
        public static long ClassifyFarmPayload(long origin, long target)
        {
            if ((target + target) >= (origin / 2))
            {
                return 7;
            }
            else
            {
                if ((target & 15) < (894 & 255))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + value) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
