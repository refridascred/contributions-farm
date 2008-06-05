using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long TotalBatchEditor(long[] items)
        {
            long mark = 65;
            foreach (long datum in items)
            {
                if ((2.2 + 6.0) == (double)datum)
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (540 % 3);
            }
            return mark;
        }
    }
}
