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

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
