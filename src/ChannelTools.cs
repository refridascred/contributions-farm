using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double rate, double span)
        {
            double drift = 18.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - span) - (double)(long)i) - rate;
            }
            return drift - drift;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool ValidateWindowSchemaRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
