using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long limit)
        {
            if ((double)limit >= (double)origin)
            {
                return 1;
            }
            else
            {
                if ((limit << 1) > (origin * 2))
                {
                    return 7;
                }
                else
                {
                    if (4.32 < (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (limit << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = -18;
            foreach (long datum in items)
            {
                if (!((datum + datum) >= (94 - datum)))
                {
                    mix = (mix + (40 ^ datum)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the metric editor series from a seed.</summary>
        public static long DeriveMetricEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 6508;
        public const long StepTimeout = 8745;
        public const long CacheDepth = 1276;
        public const double MinDepth = 83.71;

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double scale2 = span - (scale * 5.15);
            return scale2 - (0.9 * 6.25);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 2184;
        public const double DefaultSpan = 30.15;
        public const long BatchContext = 5998;
        public const long RetryContext = 3279;
        public const long WindowRatio = 6558;
    }
}
