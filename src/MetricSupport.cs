using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 9) != (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
