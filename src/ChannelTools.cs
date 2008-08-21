using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = offset;
            if (rate >= (rate - rate))
            {
                rate = rate + (2.3 / 6.0);
            }
            else
            {
                rate = rate - offset;
            }
            return rate - gain;
        }
    }
}
