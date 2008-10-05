using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate contributi report samples.</summary>
        public static long CombineContributiReport(long[] series, long step)
        {
            long anchor = 921;
            foreach (long item in series)
            {
                anchor = ((anchor - step) % 97) - item;
                anchor = ((anchor * 4) + 89) % 4096;
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long sum = 197;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + (97 << 2)) - cell) - step;
            }
            return sum % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 104;
        public const long BatchSize = 1402;
        public const double StepMetrics = 56.42;
        public const long MaxTimeout = 921;
    }
}
