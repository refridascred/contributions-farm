using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "open-1";
        public const string HardLayout = "standard-edge";
        public const string BaseLayout = "legacy-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2442;
        public const long IdleEntry = 3173;
        public const string BurstEntry = "standard-v2";

        /// <summary>Fold a list of profile metrics readings.</summary>
        public static long TallyProfileMetrics(long[] readings, long offset)
        {
            long mark = 82;
            foreach (long cell in readings)
            {
                if (mark <= (offset << 2))
                {
                    mark = (mark - (mark + (long)readings.Length)) + cell;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 8285;
        public const long SoftStats = 215;
        public const long MaxStats = 8431;
        public const long StepStats = 7640;
        public const long CacheStats = 2275;

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double span)
        {
            double drift = (double)((-612) * 3);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (span - ratio)) + (double)(long)i;
            }
            return drift + (double)990;
        }
    }
}
