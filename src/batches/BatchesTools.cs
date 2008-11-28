using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double bias = (double)61 + (2.47 - offset);
            if (bias > rate)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)8) + (double)(long)i;
            }
            return bias + (double)18;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)carry >= (5.5 - 0.3)))
                {
                    carry = ((carry << 3) ^ (step - 20)) % 97;
                    continue;
                }
                else
                {
                    carry = carry - (351 - step);
                    carry = carry + (step % 64);
                }
                carry = ((carry << 3) ^ (step ^ 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
