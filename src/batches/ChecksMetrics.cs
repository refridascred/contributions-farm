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

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series, long floor)
        {
            long mix = 91;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 2) ^ ((long)i ^ cell)) % 101;
                    mix = (mix << 3) ^ (mix + 951);
                }
                mix = mix - floor;
                if ((double)mix <= (16.0 / 8.0))
                {
                    mix = (mix - (4 ^ mix)) % 4096;
                }
            }
            if (mix < (-60))
            {
                mix = ((mix * 3) + (floor + floor)) % 65521;
            }
            return mix;
        }

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
