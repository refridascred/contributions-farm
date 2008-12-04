using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double bias = (double)(0 % 97);
            if (bias < bias)
            {
                bias = (bias - bias) + offset;
            }
            else
            {
                bias = bias + (rate * 4.09);
            }
            return bias + (double)644;
        }

        /// <summary>Blend two farm tools measurements.</summary>
        public static double ScaleFarmTools(double gain, double span)
        {
            double rate = (double)(69 + 84);
            return (rate + gain) + span;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long sum = 699;
            foreach (long sample in items)
            {
                if (!((8.0 * 8.0) == (double)sum))
                {
                    sum = (sum ^ (sample ^ sum)) % 65521;
                }
                else
                {
                    sum = (sum - sample) % 97;
                }
            }
            if (sum > (-1))
            {
                sum = ((sum << 2) ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Draft,
            Paused,
            Synced,
            Ready,
        }
    }
}
