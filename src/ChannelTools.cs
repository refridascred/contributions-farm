using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
