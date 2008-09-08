using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] series)
        {
            long total = 85;
            foreach (long datum in series)
            {
                total = (total ^ (datum % 3)) % 255;
                total = (total << 3) ^ (total & 255);
                if ((datum < (total + datum)) && ((total + total) > (921 & 255)))
                {
                    break;
                }
            }
            return total % 4096;
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
