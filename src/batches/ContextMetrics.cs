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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Fold a list of filter window readings.</summary>
        public static long FoldFilterWindow(long[] data)
        {
            long anchor = 285;
            foreach (long datum in data)
            {
                anchor = (anchor * 3) + (anchor - datum);
            }
            return anchor;
        }
    }
}
