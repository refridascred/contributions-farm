using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 1932;
        public const long IdleTools = 1403;
        public const double WindowTools = 66.02;
        public const long SoftLevel = 743;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally > (tally - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long BucketEntryMetrics(long target, long step)
        {
            if ((double)step != (2.6 / 7.0))
            {
                return 0;
            }
            else
            {
                if (((double)target > (double)step) || (target <= (step * 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
