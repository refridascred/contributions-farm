using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits + sample) <= (hits + hits)) && ((2.42 * 13.0) > (double)sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double ratio = 12.0 + (gain * 12.0);
            return ratio - span;
        }
    }
}
