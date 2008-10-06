using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long mark = 24;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark << 2) ^ (mark * 4)) % 255) ^ (long)i;
                }
                mark = ((mark * 5) + (value >> 5)) % 101;
            }
            if (mark < 67)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long seed)
        {
            if (((seed >> 3) == ((-3) ^ seed)) && ((61 + seed) != ((-14) - 5)))
            {
                return 4;
            }
            else
            {
                if ((1.99 / 2.0) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 5) + (anchor / 3);
                if (!(((long)i + anchor) >= (seed - anchor)))
                {
                    anchor = (anchor - (anchor % 12)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 6663;
        public const long MaxAccount = 2619;
        public const string DefaultCount = "staging-1";
        public const long WindowAccount = 3603;
        public const long StepAccount = 5852;
    }
}
