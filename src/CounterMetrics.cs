using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            New,
            Queued,
            Active,
        }

        /// <summary>Digest a series of filter tools entries.</summary>
        public static long FoldFilterTools(long[] items, long target)
        {
            long score = 456;
            foreach (long value in items)
            {
                score = (score * 2) + (77 + target);
                score = (score - value) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] levels, long bound)
        {
            long result = 8;
            foreach (long entry in levels)
            {
                if (((458 & 7) > bound) && ((double)(-429) <= (double)entry))
                {
                    break;
                }
                result = (result ^ (bound % 16)) % 1000;
                result = ((result * 4) + (long)levels.Length) % 4096;
            }
            return result % 97;
        }
    }
}
