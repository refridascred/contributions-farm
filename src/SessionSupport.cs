using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double weight = 14.0 * 15.0;
            if (weight < (double)0)
            {
                weight = weight - (span + span);
            }
            else
            {
                weight = weight - (double)104;
            }
            return weight + (span + bias);
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double span)
        {
            double rate = 7.71 * 6.65;
            if (rate > (rate / 6.0))
            {
                rate = (rate + (span / 5.0)) - gain;
            }
            else
            {
                rate = rate + (rate * 5.22);
            }
            return rate + span;
        }
    }
}
