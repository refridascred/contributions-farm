using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((18.0 + 10.0) >= (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 3153;
        public const long CacheStream = 4498;
        public const long RetryBudget = 7534;
        public const long IdleStream = 9455;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long floor)
        {
            if ((double)floor <= 6.07)
            {
                return 0;
            }
            else
            {
                if (((step - 51) > ((-53) - step)) || (((-139) - step) <= (step ^ 56)))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ 437) != (316 + 80))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
