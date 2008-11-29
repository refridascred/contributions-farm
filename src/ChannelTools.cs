using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseBudget = 48.17;
        public const long WindowInterval = 9897;
        public const long DefaultTools = 1031;
        public const long BatchRatio = 3585;
        public const double DefaultBudget = 67.87;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ (long)values.Length) >= (sample + sample))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - offset) + (double)(long)i;
            }
            return scale2 - (scale2 - scale2);
        }
    }
}
