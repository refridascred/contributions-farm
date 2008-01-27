using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 5694;
        public const double SoftFilter = 31.42;
        public const long MaxSize = 8994;

        /// <summary>Validate counter route readings against a bound.</summary>
        public static bool GuardCounterRouteRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3526;
        public const long MaxScore = 6510;
        public const double BaseRatio = 86.1;
        public const long LimitLevel = 774;
        public const long RetryWidth = 5341;
    }
}
