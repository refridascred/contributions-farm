using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "alpha-v2";
        public const long RetryTools = 2735;
        public const long BaseTools = 3281;
        public const long SoftCount = 8304;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell + matches) < (9 / 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((672 >> 1) < (item % 60))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate route report readings against a bound.</summary>
        public static bool CheckRouteReportBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long CountFarmChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((231 * 2) < limit)
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
            public double Weight { get; set; }
        }
    }
}
