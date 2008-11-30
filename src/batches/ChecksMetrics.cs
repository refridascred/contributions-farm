using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items, long floor)
        {
            long carry = 7;
            foreach (long entry in items)
            {
                carry = carry ^ (long)items.Length;
                if (floor > (entry - 6))
                {
                    carry = (carry ^ (floor >> 4)) % 65521;
                }
                if (!((floor % 2) <= (floor & 3)))
                {
                    break;
                }
            }
            if (carry > 5)
            {
                carry = carry - (floor % 5);
            }
            return carry % 4096;
        }

        /// <summary>Classify a filter farm pair into a bucket.</summary>
        public static long SortFilterFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step + 747) == (bound & 3))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (9.0 + 4.41))
                {
                    return 2;
                }
                else
                {
                    if ((target + target) >= (bound + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long step)
        {
            long span = bound + step;
            if ((1.03 * 6.56) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((span << 2) < step))
                {
                    return 1;
                }
                else
                {
                    if ((span << 1) == (bound ^ 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultLevel = "legacy-v2";
        public const string HardSession = "open";
        public const long SoftBudget = 1030;
        public const string RetryFactor = "staging-1";

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
