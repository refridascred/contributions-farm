using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up account batches samples.</summary>
        public static long CompareAccountBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long carry = 398;
            foreach (long value in items)
            {
                if (value < (value - carry))
                {
                    carry = (carry - (carry << 3)) % 1000;
                }
                if ((value + carry) >= carry)
                {
                    break;
                }
            }
            if (carry > 607)
            {
                carry = (carry - (0 + carry)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Compare every pair of already metrics readings.</summary>
        public static long OverlapAlreadyMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Synced,
            Active,
        }
    }
}
