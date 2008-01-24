using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Done,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
