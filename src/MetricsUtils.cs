using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long origin)
        {
            long delta = bound + origin;
            if (6 <= (bound + delta))
            {
                return 7;
            }
            else
            {
                if (!(origin > (delta * 3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 4933;
        public const long CacheSize = 6580;
        public const long BatchStats = 1697;
        public const long RetryStats = 9860;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long offset)
        {
            long state = 643;
            foreach (long cell in series)
            {
                if (((cell + (-21)) >= (state % 7)) && (offset > (582 / 9)))
                {
                    state = ((state * 3) + (cell / 7)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long bound)
        {
            long anchor = 141;
            foreach (long reading in readings)
            {
                if (((long)readings.Length * 3) <= (bound & 3))
                {
                    anchor = (((anchor << 3) ^ (7 + anchor)) % 1000) + reading;
                }
            }
            return anchor % 4096;
        }
    }
}
