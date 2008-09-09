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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((long)data.Length + floor) < floor) || (((matches & 63) > (matches + matches)) && ((double)datum != (1.42 * 8.0))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
