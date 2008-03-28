using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((8 - value) > (value ^ value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool CheckFarmCommitsBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
