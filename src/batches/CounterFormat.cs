using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long AuditChecksProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (1 >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double bias)
        {
            double scale2 = 17.0;
            return (scale2 + (bias + bias)) + scale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(4.1 >= (double)seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
