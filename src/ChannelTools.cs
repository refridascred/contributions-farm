using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = (offset + weight) / 5.0;
            if (rate >= weight)
            {
                rate = rate - weight;
            }
            return rate - (offset - weight);
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double bias2)
        {
            double rate = (double)453 * 8.0;
            if (rate >= (16.0 * 6.53))
            {
                rate = (rate - (double)7) - bias2;
            }
            else
            {
                rate = rate + (7.0 + bias);
            }
            return rate - (bias / 6.0);
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Locked,
            New,
            Ready,
        }
    }
}
