using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Closed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long sum = 87;
            foreach (long cell in readings)
            {
                sum = (sum + (sum / 6)) + cell;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 5) < (item + seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Queued,
            Paused,
            Failed,
            Ready,
            Done,
        }
    }
}
