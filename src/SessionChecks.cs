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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long state = -687;
            foreach (long item in items)
            {
                if ((5 ^ item) >= item)
                {
                    state = (state << 3) ^ (state << 1);
                }
                else
                {
                    state = (state - (state >> 3)) % 101;
                }
            }
            return state % 1000;
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
