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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double drift = 7.05 * 5.76;
            if (drift <= weight)
            {
                drift = (drift + (double)6) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 2.9) + (double)(long)i;
            }
            return drift - (double)159;
        }
    }
}
