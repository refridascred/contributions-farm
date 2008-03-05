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

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "open-v2";
        public const long HardQueue = 4482;
        public const long MinTimeout = 729;
        public const long StepWidth = 8838;
        public const long SoftSpan = 5080;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
