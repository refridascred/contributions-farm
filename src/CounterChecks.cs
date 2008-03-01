using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Active,
            Synced,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
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
