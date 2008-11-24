using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits checks measurements.</summary>
        public static double ScaleCommitsChecks(double bias, double offset)
        {
            double gain = (bias - offset) * 1.2;
            if (gain <= (double)621)
            {
                gain = gain + offset;
            }
            return gain + gain;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double gain = (double)((-1) / 9);
            if (gain > gain)
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (offset - offset)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Locate a buffer metrics reading by value.</summary>
        public static long SeekBufferMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchTimeout = 4154;
        public const string RetryFarm = "cached-1";
        public const long MinCount = 4383;
        public const string MinFarm = "open-edge";
        public const long StepFarm = 8915;

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
