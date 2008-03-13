using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((8.3 * 3.99) == (double)entry) || ((7.01 / 5.0) < (double)entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long MeasureEntryAlreadyMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((160 - bound) < (tally * 5))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream editor value.</summary>
        public static double ScaleStreamEditor(double scale, double bias)
        {
            double mean = scale;
            if (mean > (double)586)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean + (double)686;
        }
    }
}
