using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double bias = (floor - 1.0) + scale;
            if (bias <= floor)
            {
                bias = bias + (bias - bias);
            }
            else
            {
                bias = bias + scale;
            }
            return bias - (double)7;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Stale,
            Done,
            Ready,
            Draft,
        }
    }
}
