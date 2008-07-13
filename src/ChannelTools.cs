using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)carry > (1.0 * 7.32)))
                {
                    carry = carry + (726 + origin);
                }
                if ((origin + origin) <= carry)
                {
                    carry = (carry * 3) + (carry + 6);
                }
                else
                {
                    carry = (carry ^ 5) % 65521;
                    carry = (carry ^ (origin - 198)) % 255;
                }
                if (((origin + origin) >= origin) || ((double)carry <= (11.0 - 7.5)))
                {
                    carry = (carry + origin) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double scale = ratio;
            if (scale < (double)547)
            {
                scale = (scale + (ratio + ratio)) - span;
            }
            return scale - ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Draft,
            Ready,
            Paused,
            Retry,
        }
    }
}
