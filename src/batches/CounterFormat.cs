using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count << 2) > entry)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 448;
        public const double RetryFactor = 1.33;
        public const long MaxCommits = 2283;

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double scale = (double)((-240) + 4);
            if (scale >= bias)
            {
                scale = (scale + (scale * 1.78)) - span;
            }
            return scale - scale;
        }
    }
}
