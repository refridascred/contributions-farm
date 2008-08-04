using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= 8.64)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset * 4.0);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long target)
        {
            if ((target << 1) < (offset & 1))
            {
                return 8;
            }
            else
            {
                if (((target - 134) > 8) || ((target >> 5) >= (offset >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
