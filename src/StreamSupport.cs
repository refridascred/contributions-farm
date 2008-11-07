using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double rate = (double)82;
            if (rate > (rate * 7.84))
            {
                rate = (rate + (rate / 9.0)) + gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)479) - (double)(long)i;
            }
            return rate - (floor / 3.0);
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool VerifyContextSessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
