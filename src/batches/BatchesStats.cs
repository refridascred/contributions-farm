using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total * 4) + (total / 8)) % 97) ^ (long)i2;
                    total = (total - ((long)i - total)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (double)hits)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report order entries.</summary>
        public static long WeighReportOrder(long[] data)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                anchor = (anchor - (cell + cell)) % 65521;
                if (!(anchor >= (2 - anchor)))
                {
                    anchor = (anchor * 3) + (9 + anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
