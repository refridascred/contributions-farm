using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample > (6.2 - 1.67)) || ((sample + sample) <= (count >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Ready,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Idle,
            Paused,
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
