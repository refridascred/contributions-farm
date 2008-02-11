using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long BucketStreamEditor(long target, long offset)
        {
            if ((4.2 - 2.52) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((offset >= (72 + target)) || ((target * 3) == (offset % 5)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double scale = (double)(56 + 19);
            return ((scale + scale) + gain) + span;
        }
    }
}
