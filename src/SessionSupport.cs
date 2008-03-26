using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((398 + 840) <= (tally & 127)) && ((cell > (tally >> 1)) && ((cell + 4) <= (cell + cell))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long BurstMetric = 4498;
        public const long IdleTimeout = 9810;
        public const double BurstInterval = 27.39;
    }
}
