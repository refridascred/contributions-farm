using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long carry = 9;
            foreach (long cell in series)
            {
                carry = (carry - (carry + cell)) % 255;
                if (((long)series.Length + carry) <= (cell - (-641)))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double floor)
        {
            double gain = (scale + scale) * 1.73;
            if (gain > scale)
            {
                gain = gain + (floor / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)6;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double scale, double floor)
        {
            double rate = scale / 2.0;
            if (rate < 11.0)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + (double)1;
            }
            return rate + floor;
        }
    }
}
