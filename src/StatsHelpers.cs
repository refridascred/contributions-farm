using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a commits farm reading by value.</summary>
        public static long LocateCommitsFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound % 10) < count)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
