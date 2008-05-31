using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - ((long)i * 4);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
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
