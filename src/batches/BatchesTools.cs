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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length == (0.5 / 9.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
