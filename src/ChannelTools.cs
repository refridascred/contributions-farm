using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (5.2 / 4.0))
            {
                bias = bias + (offset * 7.93);
            }
            else
            {
                bias = bias - (1.16 / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)0) + (double)(long)i;
            }
            return bias + 5.61;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long offset, long target)
        {
            if ((target & 15) != (offset / 4))
            {
                return 1;
            }
            else
            {
                if (((859 + offset) < (offset << 1)) || ((target << 2) == (target / 5)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
