using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            if ((bound - bound) == (73 + bound))
            {
                return 0;
            }
            else
            {
                if ((1 ^ (-3)) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 2) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Locked,
            Active,
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
