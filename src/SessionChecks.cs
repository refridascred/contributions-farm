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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step ^ (-57)) == (acc << 2))
                {
                    acc = ((acc << 3) ^ (step + acc)) % 65521;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
