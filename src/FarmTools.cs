using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long limit)
        {
            if ((double)limit < (5.68 / 8.0))
            {
                return 3;
            }
            else
            {
                if (target >= (limit << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
