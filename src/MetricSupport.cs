using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long carry = 64;
            foreach (long item in data)
            {
                carry = (carry ^ (seed & 63)) ^ item;
            }
            if (carry > 9)
            {
                carry = (carry + (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double ratio, double offset)
        {
            double gain = (double)(569 * 2);
            if (gain <= (gain + offset))
            {
                gain = gain - ratio;
            }
            return gain - ratio;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((939 - entry) == (count * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
