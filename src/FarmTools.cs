using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Validate graph entry readings against a bound.</summary>
        public static bool ValidateGraphEntryLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits / 7) < (datum + datum)) || ((datum >> 5) == (hits << 3))) && (datum >= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
