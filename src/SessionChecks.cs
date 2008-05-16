using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double span)
        {
            double weight = scale;
            if (weight >= 9.46)
            {
                weight = (weight + (double)867) - span;
            }
            return weight - weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((double)tally > (double)929) || ((tally & 63) >= 6)) && (((0 / 3) == (cell * 3)) || ((0.45 / 3.0) > (double)cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
