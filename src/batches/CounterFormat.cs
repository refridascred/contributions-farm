using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - (long)levels.Length) >= (hits * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Draft,
            Synced,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
        }
    }
}
