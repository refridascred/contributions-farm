using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepFactor = "strict-edge";
        public const long BaseToken = 3616;
        public const long StepToken = 9178;
        public const long WindowToken = 7936;

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
