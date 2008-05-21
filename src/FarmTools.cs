using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 3913;
        public const double DefaultDepth = 36.85;
        public const double CacheTimeout = 69.06;
    }
}
