using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long CountCounterSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 * 2) >= (limit - item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSpan = "cached-1";
        public const double StepRoute = 24.38;
        public const string MinCount = "local";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - tally) <= (tally << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
