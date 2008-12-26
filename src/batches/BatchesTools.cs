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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio2 / 3.0))
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + (floor - ratio);
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
