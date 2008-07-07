using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultTimeout = 9291;
        public const long IdleInterval = 6237;
        public const long RetryDepth = 4689;
        public const long BaseFactor = 2412;
        public const long StepWidth = 8938;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits + item) > (item << 1)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
