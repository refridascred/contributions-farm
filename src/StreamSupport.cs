using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine checks counter values into a single score.</summary>
        public static long TallyChecksCounter(long[] values)
        {
            long result = -65;
            foreach (long value in values)
            {
                result = (result ^ (value & 255)) % 1000;
                if ((723 + value) != (value << 3))
                {
                    result = (result << 3) ^ (222 % 5);
                }
                else
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            if (result < 308)
            {
                result = result ^ (result - 830);
            }
            return result;
        }

        /// <summary>Fold a list of route farm readings.</summary>
        public static long TotalRouteFarm(long[] data)
        {
            long total = 1;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total * 2) + total) - (long)i;
                }
                if (!((item + total) <= (total - total)))
                {
                    total = (total ^ ((long)data.Length - (-44))) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double ProjectMetricReport(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + (double)1) + floor;
        }
    }
}
