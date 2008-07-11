using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double mean = gain;
            if (mean <= gain)
            {
                mean = mean - (span - span);
            }
            else
            {
                mean = mean - gain;
            }
            return mean - 6.0;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long seed2)
        {
            long span = seed ^ seed2;
            if ((seed2 ^ seed2) != (seed / 8))
            {
                return 5;
            }
            else
            {
                if (!((9 - span) < (seed2 - span)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] samples)
        {
            long sum = 9;
            foreach (long datum in samples)
            {
                if (((9 / 2) > (datum + datum)) || ((947 + sum) >= 8))
                {
                    sum = (sum * 2) + (datum + datum);
                }
                else
                {
                    sum = (sum - (sum % 97)) % 97;
                }
            }
            return sum;
        }
    }
}
