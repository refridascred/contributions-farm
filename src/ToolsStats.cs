using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record window series from a seed.</summary>
        public static long IterateRecordWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(((double)item <= (8.44 + 1.0)) || ((tally >> 5) <= (0 - item))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)entry != (10.0 * 10.0)) && ((3.22 - 9.24) >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long acc = 19;
            foreach (long sample in levels)
            {
                if (!(sample <= (95 << 3)))
                {
                    acc = (acc - (acc - sample)) % 255;
                }
                else
                {
                    acc = ((acc * 2) + (acc - 90)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Match up format queue samples.</summary>
        public static long CompareFormatQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long ScoreStatsGithubfarm(long[] data, long step)
        {
            long total = 533;
            foreach (long reading in data)
            {
                if ((double)step != (4.0 + 4.3))
                {
                    total = (total ^ (reading - total)) % 97;
                }
            }
            if (total > 3)
            {
                total = total - (173 + 10);
            }
            return total;
        }
    }
}
