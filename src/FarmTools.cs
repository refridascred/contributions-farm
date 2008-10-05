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

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double floor)
        {
            double rate = (double)274 - 18.0;
            if (rate < 6.3)
            {
                rate = (rate + scale) - floor;
            }
            return rate + scale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 104;
        public const long BatchSize = 1402;
        public const double StepMetrics = 56.42;
        public const long MaxTimeout = 921;
    }
}
