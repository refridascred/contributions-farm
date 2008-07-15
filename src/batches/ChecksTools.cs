using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (double)(937 ^ 10);
            if (drift >= 10.0)
            {
                drift = (drift + offset) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + 4.6;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long anchor = -498;
            foreach (long reading in levels)
            {
                if ((anchor - anchor) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 3) ^ 6) % 255) ^ reading;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
                if (!((double)anchor > (3.09 - 19.0)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 6393;
        public const double HardDepth = 6.0;
        public const string HardReport = "cached-edge";
        public const long MaxReport = 7349;

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 519;
        public const double HardRecord = 53.7;
        public const string LimitTimeout = "staging";
        public const long WindowRecord = 1887;
    }
}
