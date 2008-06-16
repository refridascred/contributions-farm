using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next channel window value from a seed.</summary>
        public static long IterateChannelWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (offset + 6.7)) + (double)(long)i;
            }
            return gain + 6.1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!!(sample >= (count + limit)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
