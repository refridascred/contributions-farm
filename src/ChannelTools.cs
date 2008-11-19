using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer report entries that pass the check.</summary>
        public static long CountBufferReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ item) <= (seen - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a profile editor reading.</summary>
        public static double BlendProfileEditor(double gain, double span)
        {
            double mean = (span - gain) + span;
            if (mean > (mean / 5.0))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - span;
            }
            return mean + mean;
        }
    }
}
