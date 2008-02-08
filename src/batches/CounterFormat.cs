using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits * 3) == (38 / 5))
                {
                    hits = ((hits + 2) ^ entry) - offset;
                }
            }
            return hits;
        }
    }
}
