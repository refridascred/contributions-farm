using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long bound)
        {
            if (6.0 > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((bound >> 3) < step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (hits / 5))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a command already reading by value.</summary>
        public static long LocateCommandAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
