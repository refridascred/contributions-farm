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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (limit > (limit % 97))
            {
                return 5;
            }
            else
            {
                if ((limit % 60) != (origin + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
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
