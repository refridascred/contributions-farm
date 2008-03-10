using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long TallyProfileBatchesOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) < (bound >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 6564;
        public const long SoftFilter = 8828;
        public const long LimitFilter = 5819;
        public const string CacheScore = "standard-edge";
    }
}
