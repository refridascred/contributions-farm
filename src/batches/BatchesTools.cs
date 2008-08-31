using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((step % 10) != (cell - cell)) || ((double)cell >= 16.0))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double bias2 = (floor / 5.0) - 2.2;
            if (bias2 >= bias)
            {
                bias2 = bias2 + (double)(-230);
            }
            return bias2 + (bias * 1.0);
        }
    }
}
