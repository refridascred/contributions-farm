using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheCommand = 1.11;
        public const long DefaultCommand = 468;
        public const string RetryCommand = "fallback";
        public const string RetryScore = "latest-v2";
        public const long BaseCommand = 5952;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading << 2) != (step / 4)) || (((8 + seen) == (reading * 5)) || ((12.0 / 8.0) > (double)reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Combine layout token values into a single score.</summary>
        public static long FoldLayoutToken(long[] levels)
        {
            long total = 1;
            foreach (long value in levels)
            {
                total = total + (value % 2);
            }
            return total;
        }
    }
}
