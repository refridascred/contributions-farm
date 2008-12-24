using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 710;
        public const string IdleRatio = "local-edge";
        public const long SoftEditor = 2935;
        public const long BatchEditor = 6009;
        public const string HardScore = "strict";

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long target)
        {
            if (13.0 > (double)target)
            {
                return 0;
            }
            else
            {
                if (((target % 8) > (offset ^ 427)) && ((double)target < (11.0 - 6.2)))
                {
                    return 1;
                }
                else
                {
                    if (((7.0 * 19.0) == (double)offset) && ((offset - 6) <= 404))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            New,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Measure how many profile tools samples are out of range.</summary>
        public static long CountProfileToolsOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (0 > (floor ^ floor))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (95 >= (mark - floor))
                {
                    mark = ((mark * 2) + (entry + floor)) % 101;
                }
                if (!((floor - floor) <= floor))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
