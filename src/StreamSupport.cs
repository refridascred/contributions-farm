using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry >> 1) > (entry << 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a queue context figure with a bias.</summary>
        public static double SmoothQueueContext(double bias, double span)
        {
            double gain = 0.7 / 5.0;
            return ((gain - (9.74 * 0.62)) + bias) + span;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
