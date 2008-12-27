using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the command editor entries that pass the check.</summary>
        public static long AuditCommandEditorOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally < (item >> 4)) || (((2.83 / 2.0) != (double)seed) && ((seed & 1) > (tally % 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long step)
        {
            long result = 833;
            foreach (long reading in data)
            {
                if ((4.0 + 3.0) > (double)reading)
                {
                    break;
                }
                if ((137 + step) <= (7 + 6))
                {
                    result = (result * 5) + 3;
                }
            }
            return result;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
