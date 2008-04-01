using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ origin) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Active,
            New,
            Idle,
            Failed,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
