using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank filter window input into a small class.</summary>
        public static long BucketFilterWindow(long offset, long step)
        {
            if ((step % 12) != (offset / 2))
            {
                return 5;
            }
            else
            {
                if ((5.0 * 3.32) != (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((92 + offset) >= (step & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = gain - gain;
            if (rate <= (7.8 - 2.63))
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 2.67) - (double)(long)i;
            }
            return rate + (double)233;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "local-edge";
        public const long HardSchema = 7108;
        public const long BaseTimeout = 4998;
        public const double BurstSchema = 23.18;
        public const double LimitSchema = 12.39;
    }
}
