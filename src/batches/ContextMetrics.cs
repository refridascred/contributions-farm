using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((71 << 1) == (item >> 1))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = 6.02;
            if (bias2 >= 19.0)
            {
                bias2 = ((bias2 + bias2) - bias) - span;
            }
            return bias2 - (double)1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count - count) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of payload checks readings.</summary>
        public static long ScorePayloadChecks(long[] readings, long target)
        {
            long anchor = 70;
            foreach (long sample in readings)
            {
                if (sample <= (449 * 2))
                {
                    anchor = (anchor + (anchor / 6)) - target;
                }
            }
            return anchor;
        }
    }
}
