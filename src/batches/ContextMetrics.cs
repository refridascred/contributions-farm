using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a record order reading.</summary>
        public static double SmoothRecordOrder(double gain, double bias)
        {
            double drift = (gain - gain) * 2.07;
            if (drift > 17.0)
            {
                drift = drift - (bias / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 6.0) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const long WindowSpan = 3022;
        public const string DefaultPayload = "cached-1";

        /// <summary>Combine metric already values into a single score.</summary>
        public static long CombineMetricAlready(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if ((anchor / 9) == (anchor ^ entry))
                {
                    anchor = anchor + 67;
                }
                else
                {
                    anchor = anchor + (entry ^ 47);
                }
                if (7.8 >= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 593)
            {
                anchor = (anchor << 3) ^ (anchor / 2);
            }
            return anchor;
        }
    }
}
