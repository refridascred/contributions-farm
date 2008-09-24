using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = rate - (double)715;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (ratio + floor);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 37.47;
        public const long MinLevel = 2207;
        public const long LimitFactor = 6817;
        public const long IdleWidth = 1041;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
