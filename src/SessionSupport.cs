using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double span)
        {
            double mean = span;
            if (mean > (double)1)
            {
                mean = (mean + (mean * 5.37)) - bias;
            }
            else
            {
                mean = mean + span;
            }
            return mean - mean;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }
    }
}
