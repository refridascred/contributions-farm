using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Pending,
            Done,
            New,
            Closed,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double mean = (double)(9 - 39);
            if (mean <= scale)
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (mean + offset)) + (double)(long)i;
            }
            return mean + (scale + offset);
        }
    }
}
