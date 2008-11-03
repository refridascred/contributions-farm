using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi githubfarm samples are out of range.</summary>
        public static long TallyContributiGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)(-3) != (double)sample)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph counter reading.</summary>
        public static double AdjustGraphCounter(double scale, double floor)
        {
            double ratio = scale - 2.37;
            if (ratio <= (8.4 * 5.0))
            {
                ratio = (ratio - (ratio + ratio)) + floor;
            }
            else
            {
                ratio = ratio + (3.0 * 4.48);
            }
            return ratio - (scale / 4.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long total = 518;
            foreach (long cell in values)
            {
                if ((total + total) == (total ^ cell))
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total < 38)
            {
                total = ((total << 2) ^ (total ^ total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((5 ^ tally) != (datum + datum))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
