using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Retry,
            New,
            Failed,
            Synced,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long bound)
        {
            if ((bound * 3) > (8 + 549))
            {
                return 6;
            }
            else
            {
                if ((double)step <= (7.5 + 2.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (bound - 0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
