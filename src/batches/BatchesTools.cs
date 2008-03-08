using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long mix = 7;
            foreach (long reading in data)
            {
                mix = (mix + (reading >> 5)) % 97;
            }
            if (mix < 6)
            {
                mix = (mix << 2) ^ (653 << 3);
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstCount = 6698;
        public const long BatchStats = 9560;
        public const long LimitInterval = 1496;
        public const double SoftStats = 25.42;
        public const long StepInterval = 3143;
    }
}
