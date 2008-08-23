using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit filter metric readings against a rule.</summary>
        public static long MeasureFilterMetricHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)item < (double)0) || (((78 + item) < floor) || ((5.56 / 5.0) <= (double)count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((sample << 3) == (sample + sample)) && ((tally + tally) > (tally - sample))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of commits githubfarm entries.</summary>
        public static long FoldCommitsGithubfarm(long[] readings)
        {
            long total = 496;
            foreach (long datum in readings)
            {
                total = ((total - (total - 917)) % 97) + datum;
            }
            if (total > 936)
            {
                total = (total + (total * 4)) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftWidth = 6382;
        public const double RetryBudget = 2.74;
        public const long RetryReport = 8218;
        public const string HardDepth = "strict";
        public const long BaseReport = 1040;
    }
}
