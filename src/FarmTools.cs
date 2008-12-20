using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCount = 19.94;
        public const long MaxTimeout = 9187;
        public const double IdleLevel = 81.59;
        public const long MaxCommits = 7228;

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = (mix * 3) + cell;
            }
            return mix;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double weight = gain - (offset / 9.0);
            return weight - gain;
        }
    }
}
