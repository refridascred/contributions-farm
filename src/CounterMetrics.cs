using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7360;
        public const long MinQueue = 7298;
        public const long BurstQueue = 7139;
        public const string BatchQueue = "stable-1";

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long offset)
        {
            long score = 0;
            foreach (long value in values)
            {
                if (!((15 - value) >= (score << 3)))
                {
                    score = ((score * 4) + (offset << 1)) % 255;
                }
            }
            if (score > 42)
            {
                score = score + (offset + 17);
            }
            return score % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((matches ^ reading) < reading) || ((matches & 63) > reading)) || (((reading % 60) < reading) || ((reading / 9) >= reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2678;
        public const long BatchContext = 8677;
        public const long BurstContext = 5305;
        public const double WindowContext = 36.64;
    }
}
