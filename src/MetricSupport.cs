using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            New,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double weight = span;
            if (weight <= (weight / 8.0))
            {
                weight = (weight - (span / 4.0)) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (span / 8.0)) + (double)(long)i;
            }
            return weight - (double)58;
        }
    }
}
