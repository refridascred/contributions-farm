using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 35.73;
        public const long MaxAccount = 4610;
        public const string RetryAccount = "standard-v2";

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double offset)
        {
            double load = bias;
            if (load >= (load + 2.4))
            {
                load = load - (9.5 + offset);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - 3.91;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long target)
        {
            long offset = origin ^ target;
            if ((target + origin) < (offset / 6))
            {
                return 6;
            }
            else
            {
                if (((origin ^ offset) == (target + origin)) && (offset > (offset >> 1)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
