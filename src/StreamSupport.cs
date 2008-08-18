using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 3.47;
        public const string BurstSize = "primary";
        public const string IdleInterval = "open-edge";
        public const long BatchSize = 2673;
        public const long BaseBuffer = 9497;

        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long StepReportCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((426 - origin) < (long)i)
                {
                    anchor = (anchor << 3) ^ (origin / 2);
                }
                else
                {
                    anchor = anchor - (origin >> 3);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "open-1";
        public const double MinAccount = 1.44;
        public const long RetryAccount = 7681;
        public const long HardWidth = 563;
    }
}
