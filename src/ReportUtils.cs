using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long step)
        {
            if ((target >> 4) < (1 + target))
            {
                return 6;
            }
            else
            {
                if (((step + 3) >= (target * 2)) && ((step - target) >= (step >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((target < (target - step)) || ((step * 4) != (target + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target >= (2.71 - 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((2.7 + 1.4) < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Scale a batches batch figure with a bias.</summary>
        public static double SmoothBatchesBatch(double rate, double floor)
        {
            double mean = rate;
            if (mean >= floor)
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (4.0 * 3.1)) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((7.9 - 0.1) < (double)seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
