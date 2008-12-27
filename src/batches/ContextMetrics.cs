using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (carry >= floor)
                {
                    carry = (carry + carry) % 101;
                }
                long delta = (long)i;
                if (((long)i ^ delta) > (floor - (long)i))
                {
                    delta = ((delta * 2) + (long)i) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const long CacheCount = 1996;
        public const long MinStats = 3981;

        /// <summary>Check that every stats format entry stays within the limit.</summary>
        public static bool ValidateStatsFormatLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9998;
        public const long WindowCommand = 2009;
        public const double DefaultLevel = 9.32;
    }
}
