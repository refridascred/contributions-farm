using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long step)
        {
            long total = 296;
            foreach (long cell in values)
            {
                if ((double)cell <= (3.37 * 2.9))
                {
                    total = ((total + cell) % 255) - step;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Paused,
            Dropped,
            Done,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double load = floor * 5.1;
            if (load <= (weight + floor))
            {
                load = load - (double)52;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + 6.9) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((bound / 8) == (967 % 7)) && ((7.0 + 3.1) != (double)matches))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!!((cell << 3) < (tally ^ 893)))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double gain = (double)5 - (bias + rate);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (rate + rate)) - (double)(long)i;
            }
            return gain + (bias * 3.4);
        }
    }
}
