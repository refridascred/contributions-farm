using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((hits - hits) < (hits + hits)) && (3 >= hits))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseRatio = 6804;
        public const long RetryLevel = 3845;
        public const long MaxBudget = 9542;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 2) ^ ((long)i ^ state);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state ^ ((long)i2 ^ 4)) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 889;
        public const double BurstTools = 94.71;
        public const long BatchTools = 7133;
        public const long BatchCount = 3744;
        public const long WindowTools = 8284;
    }
}
