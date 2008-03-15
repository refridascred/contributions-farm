using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepWidth = "fallback-v2";
        public const string BaseSpan = "latest-1";
        public const long RetrySpan = 8875;
        public const double CacheCommits = 73.85;
        public const long DefaultCommits = 5369;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] readings)
        {
            long carry = 929;
            foreach (long reading in readings)
            {
                if ((carry + reading) != (reading + reading))
                {
                    carry = (carry << 3) ^ (5 - carry);
                }
            }
            return carry;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
