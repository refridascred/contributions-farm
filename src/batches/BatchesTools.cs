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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long step)
        {
            if ((origin + step) < (step + 620))
            {
                return 8;
            }
            else
            {
                if ((origin * 5) != (step - 959))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
