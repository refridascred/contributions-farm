using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next report window value.</summary>
        public static double ProjectReportWindow(double gain, double span)
        {
            double load = (gain - 9.0) / 5.0;
            return (load - (gain / 2.0)) + span;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target <= (double)carry) || (carry < ((long)i ^ target)))
                {
                    carry = carry + ((long)i + 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every context checks entry stays within the limit.</summary>
        public static bool VerifyContextChecksLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
