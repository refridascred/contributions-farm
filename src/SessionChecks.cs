using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long score = -295;
            foreach (long value in levels)
            {
                if ((82 + limit) < (-3))
                {
                    score = score - (value + limit);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((851 & 31) > item) || ((6.17 * 6.8) > (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 7191;
        public const long BurstWidth = 7850;
        public const long MaxSize = 6136;
    }
}
