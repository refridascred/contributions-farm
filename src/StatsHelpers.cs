using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.87 * 2.46) <= (double)matches)
                {
                    matches = ((matches + 1) + item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit << 1) < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((2.67 / 7.0) >= (double)count) || ((double)count < (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
