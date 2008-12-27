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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseWidth = 9042;
        public const long HardFactor = 538;
        public const long DefaultGithubfarm = 595;
        public const long IdleGithubfarm = 7339;
        public const long BatchGithubfarm = 5201;

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

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
