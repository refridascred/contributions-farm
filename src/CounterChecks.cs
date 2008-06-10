using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if (72 > (cell + sum))
                {
                    sum = sum ^ (cell + 79);
                }
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Closed,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally >> 4) < tally))
                {
                    tally = ((tally + 3) + item) - floor;
                }
            }
            return tally;
        }
    }
}
