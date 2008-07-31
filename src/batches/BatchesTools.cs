using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= 96)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next farm batches value.</summary>
        public static double SmoothFarmBatches(double scale, double offset)
        {
            double drift = (double)608 / 3.0;
            if (drift <= (double)96)
            {
                drift = (drift - (offset + offset)) - scale;
            }
            return drift - drift;
        }
    }
}
