using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = 2.0;
            if (ratio >= (9.35 - ratio))
            {
                ratio = (ratio + (double)774) - span;
            }
            else
            {
                ratio = ratio - (double)6;
            }
            return ratio - weight;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
