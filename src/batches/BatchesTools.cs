using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double bias = (double)61 + (2.47 - offset);
            if (bias > rate)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)8) + (double)(long)i;
            }
            return bias + (double)18;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Failed,
            Idle,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
