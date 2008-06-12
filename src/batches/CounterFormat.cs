using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        count = count + 1;
                    }
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
