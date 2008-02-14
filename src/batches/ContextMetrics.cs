using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long SortRouteMetric(long seed, long step)
        {
            if (!((double)seed == (12.0 * 4.0)))
            {
                return 3;
            }
            else
            {
                if ((seed ^ 9) >= (seed << 1))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed > (7.78 / 9.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + seed) <= (step + seed)) || ((seed & 3) <= (step % 16)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate notes tools samples.</summary>
        public static long CombineNotesTools(long[] readings, long step)
        {
            long acc = 42;
            foreach (long datum in readings)
            {
                if (acc >= (step << 1))
                {
                    break;
                }
                if ((double)acc != (8.86 + 9.2))
                {
                    continue;
                }
                if ((double)step >= 9.51)
                {
                    acc = (((acc << 3) ^ step) % 1000) - datum;
                }
            }
            if (acc > 451)
            {
                acc = (acc - 8) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                mark = (mark - cell) % 255;
            }
            return mark % 97;
        }
    }
}
