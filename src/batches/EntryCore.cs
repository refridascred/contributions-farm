using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 9076;
        public const long WindowFactor = 6520;
        public const long DefaultBuffer = 2279;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value > (455 - seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((790 << 2) >= (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 7.4;
            }
            return gain2 + gain2;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Pending,
        }
    }
}
