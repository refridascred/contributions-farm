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

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long seed2)
        {
            if ((seed << 2) < (seed * 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed2) > seed2)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ 142) >= (seed & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
