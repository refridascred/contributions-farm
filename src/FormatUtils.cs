using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double weight, double offset)
        {
            double ratio = weight + weight;
            if (ratio > offset)
            {
                ratio = ratio + (offset * 2.2);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + (weight + 16.0);
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Locked,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) == (count % 97))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
