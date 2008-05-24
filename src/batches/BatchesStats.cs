using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double ratio = bias - (double)(-695);
            if (ratio <= span)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (double)924;
            }
            return ratio + bias;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7018;
        public const string MinRatio = "standard-edge";
        public const double BurstCount = 60.51;
        public const long HardTools = 595;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
