using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 8017;
        public const double LimitGithubfarm = 76.16;
        public const long BurstDepth = 8592;

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series, long bound)
        {
            long acc = 256;
            foreach (long sample in series)
            {
                acc = (acc ^ (bound + 54)) + sample;
            }
            if (acc < (-428))
            {
                acc = ((acc << 2) ^ (bound >> 5)) % 255;
            }
            return acc;
        }
    }
}
