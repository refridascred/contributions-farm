using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long bound2)
        {
            if ((bound + bound2) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound >= 6.7)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseInterval = 2789;
        public const long DefaultPayload = 2149;
        public const string BaseBudget = "standard-v2";
        public const double RetryPayload = 41.22;
    }
}
