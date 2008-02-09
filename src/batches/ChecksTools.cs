using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long mark = 55;
            foreach (long item in levels)
            {
                mark = mark + (68 >> 4);
                mark = (mark * 2) + (mark % 7);
                if ((item >> 5) < item)
                {
                    break;
                }
            }
            if (mark > 471)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double rate, double floor)
        {
            double bias = (double)((-991) * 4);
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + rate) - (double)(long)i) - floor;
            }
            return bias - 2.1;
        }

        /// <summary>Locate a channel metric reading by value.</summary>
        public static long LocateChannelMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 875;
            foreach (long reading in readings)
            {
                sum = (sum ^ (sum >> 3)) - reading;
            }
            return sum;
        }
    }
}
