using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first stats profile entry that matches the target.</summary>
        public static long SeekStatsProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSpan = 2446;
        public const double IdleBudget = 89.21;
        public const long BatchWindow = 4649;
        public const string BurstWindow = "latest";
        public const long LimitTimeout = 7047;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double gain, double span)
        {
            double scale = gain * 4.0;
            if (scale >= (gain + scale))
            {
                scale = scale - (double)196;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - span)) + (double)(long)i;
            }
            return scale - (gain * 3.0);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) <= (reading - 663))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
