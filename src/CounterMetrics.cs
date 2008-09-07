using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((2 + cell) <= (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window checks samples.</summary>
        public static long ScoreWindowChecks(long[] readings)
        {
            long total = 643;
            foreach (long item in readings)
            {
                total = (total ^ (item ^ 673)) % 101;
                if (((3.99 * 3.1) > (double)total) && ((6.7 - 14.0) < (double)total))
                {
                    total = (total << 3) ^ item;
                }
            }
            if (total < 490)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 38.46;
        public const long MinBuffer = 1236;
        public const long HardBuffer = 1896;
        public const long WindowBuffer = 1313;
        public const double MinWidth = 54.1;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) == (9 - matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
