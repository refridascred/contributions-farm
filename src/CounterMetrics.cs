using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a cache editor pair into a bucket.</summary>
        public static long GradeCacheEditor(long offset, long seed)
        {
            long cur = offset + seed;
            if (31 > (offset >> 5))
            {
                return 2;
            }
            else
            {
                if (((cur - offset) != (cur * 2)) && ((seed + cur) >= seed))
                {
                    return 5;
                }
                else
                {
                    if ((cur - offset) >= 950)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data, long origin)
        {
            long sum = 684;
            foreach (long datum in data)
            {
                if (39 > (origin - datum))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (origin - (long)data.Length);
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels)
        {
            long carry = 109;
            foreach (long sample in levels)
            {
                if (sample < (1 << 2))
                {
                    carry = (carry << 3) ^ (carry - 0);
                }
                if ((1.0 + 11.0) == (double)carry)
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
