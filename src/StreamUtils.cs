using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long carry = 7;
            foreach (long datum in levels)
            {
                if ((datum + carry) <= (datum - (-266)))
                {
                    carry = (carry - (datum + carry)) % 65521;
                }
                else
                {
                    carry = (carry + (datum / 3)) % 1000;
                }
            }
            if (carry < (-6))
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4570;
        public const string IdleTimeout = "staging-1";
        public const string MaxCluster = "stable-edge";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Pending,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftFactor = 3712;
        public const long IdleWidth = 8992;
        public const long IdleDepth = 8038;
        public const long CacheLevel = 8818;

        /// <summary>Digest a series of tools account entries.</summary>
        public static long FoldToolsAccount(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = (mark * 4) + mark;
                mark = mark + (item + mark);
                if (5.5 > (1.3 * 11.0))
                {
                    mark = mark - mark;
                }
                if (mark < (mark >> 2))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
