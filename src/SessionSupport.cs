using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the queue metric entries that pass the check.</summary>
        public static long MeasureQueueMetricOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry ^ entry) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long PairCommitsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
