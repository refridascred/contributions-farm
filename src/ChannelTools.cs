using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= 8.64)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Check that every report cluster entry stays within the limit.</summary>
        public static bool ValidateReportClusterLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
