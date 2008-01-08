using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Retry,
            Stale,
            Done,
            Closed,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double mean = weight + (double)(-7);
            if (mean < offset)
            {
                mean = mean - (3.54 - offset);
            }
            return mean - (double)(-943);
        }
    }
}
