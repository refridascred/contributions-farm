using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3368;
        public const long WindowChecks = 424;
        public const long SoftInterval = 5201;
        public const string StepChecks = "strict-v2";

        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long AuditCommitsCommandHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count > (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((443 + step) <= (609 / 9))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many already stats samples are out of range.</summary>
        public static long MeasureAlreadyStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (9.98 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
