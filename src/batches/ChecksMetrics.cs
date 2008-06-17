using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a checks farm value against two limits.</summary>
        public static long ClassifyChecksFarm(long bound, long step)
        {
            if ((bound > step) || ((step << 3) <= (bound % 5)))
            {
                return 7;
            }
            else
            {
                if (!((239 ^ 4) <= (bound << 1)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 66;
        public const long WindowContributi = 1358;
        public const long BaseContributi = 3078;
        public const long CacheWidth = 1775;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 3508;
        public const long DefaultSpan = 4925;
        public const string HardContext = "legacy";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many githubfarm report samples are out of range.</summary>
        public static long MeasureGithubfarmReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches ^ reading) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
