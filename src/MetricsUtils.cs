using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if ((559 >> 2) >= (cell * 3))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = (state ^ seed) % 65521;
                }
            }
            if (state < 14)
            {
                state = ((state * 4) + seed) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                if ((double)acc >= (10.0 * 1.9))
                {
                    acc = (acc + (acc + origin)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 1987;
        public const long HardBatch = 2261;
        public const long MaxBatch = 4068;
        public const string SoftBatch = "alpha-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long floor)
        {
            if (!((double)step >= (5.63 + 1.2)))
            {
                return 2;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
