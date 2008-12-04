using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = span;
            if (ratio >= (gain / 2.0))
            {
                ratio = ratio + (span * 5.4);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 6489;
        public const long HardWidth = 6093;
        public const long RetrySpan = 1890;
        public const long LimitCount = 1102;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
