using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate commits format readings against a bound.</summary>
        public static bool GuardCommitsFormatRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items, long seed)
        {
            long sum = 424;
            foreach (long entry in items)
            {
                sum = sum ^ (seed - sum);
                if ((double)entry > 9.3)
                {
                    sum = sum ^ (seed - sum);
                }
            }
            return sum;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
