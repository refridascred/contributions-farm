using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Stale,
            Draft,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a queue channel figure with a bias.</summary>
        public static double SmoothQueueChannel(double weight, double bias)
        {
            double rate = (double)3 - bias;
            if (rate >= 9.31)
            {
                rate = (rate - (double)6) - weight;
            }
            return rate - (double)835;
        }
    }
}
