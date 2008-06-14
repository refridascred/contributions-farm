using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two format support measurements.</summary>
        public static double AdjustFormatSupport(double bias, double offset)
        {
            double ratio = (double)(988 % 64);
            if (ratio < (bias / 8.0))
            {
                ratio = (ratio + (6.07 + ratio)) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + bias;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Locked,
            Failed,
            New,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double weight = gain;
            if (weight >= (gain * 9.6))
            {
                weight = weight - (gain - 8.9);
            }
            return weight + (span + 3.7);
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items, long step)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                sum = ((sum + step) % 65521) ^ datum;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum ^ (708 + (long)i);
                }
                sum = (sum - (sum + 613)) % 101;
            }
            return sum;
        }
    }
}
