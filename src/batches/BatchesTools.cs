using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 2114;
        public const long SoftToken = 6893;
        public const long StepToken = 4547;
        public const long WindowLevel = 2516;
    }
}
