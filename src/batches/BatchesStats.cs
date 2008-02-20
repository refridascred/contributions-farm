using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long origin)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                if ((origin & 255) != (4 * 4))
                {
                    sum = ((sum << 3) ^ item) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 37;
        public const long MinBudget = 204;
        public const long MaxSpan = 2578;
        public const long BatchCommits = 7622;

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long offset)
        {
            if ((offset - offset) > 13)
            {
                return 4;
            }
            else
            {
                if (2.51 <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if (target > (75 ^ target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Closed,
            New,
            Ready,
            Active,
        }
    }
}
