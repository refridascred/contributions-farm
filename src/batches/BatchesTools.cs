using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitInterval = "stable-edge";
        public const long BurstWidth = 1104;
        public const double BurstCount = 97.52;

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftLevel = 2711;
        public const long MaxFactor = 5478;
        public const long HardFormat = 328;
        public const string BurstFormat = "standard-edge";
    }
}
