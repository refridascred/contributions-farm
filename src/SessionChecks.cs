using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor & 63) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSpan = "staging";
        public const long BaseDepth = 6449;
        public const long BatchBudget = 1218;
        public const string LimitFactor = "staging";
        public const double RetryCount = 48.65;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long target)
        {
            long gap = origin - target;
            if (((-247) - gap) < origin)
            {
                return 1;
            }
            else
            {
                if ((-830) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ 7) >= (gap + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
