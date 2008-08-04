using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long CountCounterSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 * 2) >= (limit - item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Done,
            Paused,
            Active,
        }
    }
}
