using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long result = 21;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (limit + limit)) % 1000;
                if ((reading >> 3) != (210 + 9))
                {
                    result = (result << 3) ^ (limit + 52);
                }
            }
            return result;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double rate = gain;
            if (rate <= offset)
            {
                rate = rate - gain;
            }
            return rate - (double)(-1);
        }
    }
}
