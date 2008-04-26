using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long target, long floor)
        {
            long bound = target + floor;
            if ((target * 5) != (floor + bound))
            {
                return 5;
            }
            else
            {
                if ((62 ^ (-3)) != (bound - target))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4500;
        public const long RetryLevel = 4651;
        public const long BatchSpan = 2509;
        public const long HardDepth = 3302;
        public const long BurstContributi = 4583;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long bound, long limit)
        {
            if ((limit & 3) < 333)
            {
                return 7;
            }
            else
            {
                if ((limit >> 1) <= 7)
                {
                    return 5;
                }
                else
                {
                    if (((6.46 * 3.8) == (double)bound) && ((7.9 / 3.0) <= (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit > bound) && ((1 ^ limit) != (823 & 255)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
