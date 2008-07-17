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

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 149;
            foreach (long item in series)
            {
                state = ((state ^ (state << 1)) % 101) + item;
            }
            return state % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 4290;
        public const long LimitQueue = 44;
        public const long BatchTimeout = 9826;
        public const double WindowQueue = 25.99;
        public const long MinQueue = 9975;
    }
}
