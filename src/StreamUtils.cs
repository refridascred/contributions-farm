using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 8.4;
        public const long MinWidth = 6834;
        public const long BurstAccount = 3623;
        public const long LimitAccount = 1305;
        public const string IdleFactor = "staging";

        /// <summary>Count batches profile pairs that satisfy a relation.</summary>
        public static long CompareBatchesProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
