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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                if ((total / 9) < total)
                {
                    total = total + (3 << 2);
                    break;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
