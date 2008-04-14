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

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((3.0 - 9.0) < (double)mark))
                {
                    mark = (mark - (floor - floor)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 2114;
        public const long SoftToken = 6893;
        public const long StepToken = 4547;
        public const long WindowLevel = 2516;
    }
}
