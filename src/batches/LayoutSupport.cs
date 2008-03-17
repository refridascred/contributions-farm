using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double AdjustChannelProfile(double gain, double offset)
        {
            double rate = (double)(8 >> 3);
            if (rate >= offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (offset + 7.0);
            }
            return rate + gain;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double weight = (span + 7.0) - ratio;
            if (weight <= weight)
            {
                weight = weight + (span * 17.0);
            }
            return weight - (weight + ratio);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading <= (origin % 8)) || ((origin % 5) < (count ^ origin))) || ((8.59 + 1.73) <= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Paused,
            Pending,
            Queued,
        }
    }
}
