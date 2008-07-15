using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Find the first order stats entry that matches the target.</summary>
        public static long FindOrderStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally + 858))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
