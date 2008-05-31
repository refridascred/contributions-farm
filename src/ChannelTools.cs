using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long LocateSupportLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 2) != (cell >> 1)) || (((920 - cell) > (122 / 9)) || ((6.5 / 6.0) >= (double)cell)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double gain = (double)((-13) + 5);
            if (gain < bias)
            {
                gain = (gain - (double)509) + ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - (gain - 7.28);
        }
    }
}
