using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 4654;
        public const string RetryInterval = "stable";
        public const long BatchCommand = 5791;
        public const long WindowDepth = 1815;
        public const long LimitSize = 6691;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi batches value.</summary>
        public static double ProjectContributiBatches(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 >= 13.0)
            {
                gain2 = (gain2 + (gain - gain2)) + offset;
            }
            return gain2 - (gain - gain2);
        }
    }
}
