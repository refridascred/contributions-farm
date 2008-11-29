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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)step > (2.7 + 7.4)) && ((390 / 3) <= (datum + datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
