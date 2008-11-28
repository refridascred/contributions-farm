using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
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
