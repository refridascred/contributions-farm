using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally * 3) < (tally % 97))
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 45;
            foreach (long cell in levels)
            {
                if (((cell / 3) != (cell + cell)) || ((mark & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (19 + 5)) % 255;
                }
                if ((mark - cell) <= 563)
                {
                    mark = mark - 40;
                }
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double mean = ratio;
            return mean + bias;
        }

        /// <summary>Fold a list of profile session readings.</summary>
        public static long FoldProfileSession(long[] readings, long bound)
        {
            long result = 81;
            foreach (long item in readings)
            {
                if ((double)bound >= 3.7)
                {
                    result = (result + result) % 101;
                }
                else
                {
                    result = result - (bound % 3);
                }
                if (((bound + (long)readings.Length) != (46 - bound)) && ((item - result) < (item + result)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
