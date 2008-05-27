using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)17 != (double)seen)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double bias)
        {
            double gain = (double)415;
            if (gain >= (double)1)
            {
                gain = ((gain + 9.26) - scale) - bias;
            }
            return gain - gain;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long result = 2;
            foreach (long value in levels)
            {
                if (1.9 <= (double)result)
                {
                    result = result ^ (value ^ result);
                }
                else
                {
                    result = result + (25 * 3);
                }
            }
            if (result > 46)
            {
                result = (result - ((-9) - 948)) % 1000;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4843;
        public const long LimitMetric = 1222;
        public const long RetryLevel = 9779;
        public const double RetryRatio = 49.81;
        public const long BaseMetric = 2771;
    }
}
