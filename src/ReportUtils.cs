using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long origin)
        {
            long diff = step - origin;
            if ((diff + diff) >= (origin - origin))
            {
                return 6;
            }
            else
            {
                if (((origin << 1) > origin) && (((-261) + origin) > 1))
                {
                    return 1;
                }
                else
                {
                    if ((origin & 127) > (origin % 12))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0 ^ 335) >= (step - diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile counter entry stays within the limit.</summary>
        public static bool CheckProfileCounterRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
