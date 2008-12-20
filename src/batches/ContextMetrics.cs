using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] readings, long limit)
        {
            long anchor = -183;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (507 ^ anchor)) % 101) - (long)i;
                }
                if ((anchor * 2) <= (limit + limit))
                {
                    anchor = ((anchor * 2) + (entry + 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
