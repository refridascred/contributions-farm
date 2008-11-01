using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepTimeout = 3478;
        public const long CacheInterval = 3777;
        public const long BurstWidth = 2892;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double ratio = (7.5 - gain) + (7.9 * 2.0);
            if (ratio < (offset * 3.39))
            {
                ratio = ratio + (gain + offset);
            }
            else
            {
                ratio = ratio - (ratio + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)289) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
