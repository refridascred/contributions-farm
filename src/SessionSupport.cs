using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long offset2)
        {
            if (offset2 >= (offset / 7))
            {
                return 1;
            }
            else
            {
                if ((offset2 << 1) < offset2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= 0.2)
            {
                drift = drift - 6.98;
            }
            else
            {
                drift = drift + (9.7 + ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift - offset)) + (double)(long)i;
            }
            return drift - (double)3;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}
