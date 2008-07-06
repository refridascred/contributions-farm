using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long step)
        {
            if ((bound <= (bound + step)) || ((bound ^ step) >= 8))
            {
                return 5;
            }
            else
            {
                if ((double)bound == (7.3 * 3.1))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch graph samples.</summary>
        public static long FoldBatchGraph(long[] readings, long offset)
        {
            long anchor = 49;
            foreach (long sample in readings)
            {
                anchor = ((anchor - (sample - (-5))) % 255) + offset;
            }
            return anchor;
        }
    }
}
