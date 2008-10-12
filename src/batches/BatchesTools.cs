using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = (bias * 6.0) - bias;
            if (load <= floor)
            {
                load = load - (load * 5.31);
            }
            return load + bias;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen / 2) > (seen >> 3))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetrySpan = 15.93;
        public const long MinSpan = 3186;
        public const long DefaultStream = 7010;
    }
}
