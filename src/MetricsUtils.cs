using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long TallyToolsStream(long[] data, long offset)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                mix = (mix * 2) + (cell * 4);
                if (!((5 - offset) <= mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
