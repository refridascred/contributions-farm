using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of batch support entries.</summary>
        public static long FoldBatchSupport(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (!(sum >= reading))
                {
                    sum = sum - (reading >> 4);
                }
                if (reading <= 985)
                {
                    break;
                }
            }
            if (sum < 1)
            {
                sum = sum ^ (sum & 7);
            }
            return sum;
        }

        /// <summary>Roll a session githubfarm counter forward.</summary>
        public static long DeriveSessionGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!(target <= (target + anchor)))
                {
                    anchor = anchor + (anchor + target);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 49.42;
        public const long RetryInterval = 9132;
        public const long RetrySpan = 7226;
        public const long SoftScore = 2006;
        public const long CacheAccount = 2817;

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "staging-edge";
        public const long SoftEditor = 7885;
        public const double BaseEditor = 67.21;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
