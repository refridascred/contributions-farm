using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double scale = (double)(61 + 5);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (weight + 6.4)) + (double)(long)i) - span;
            }
            return scale + (double)553;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 5.51;
        public const long HardSpan = 5846;
        public const long DefaultGithubfarm = 8226;
        public const string StepDepth = "local-v2";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
