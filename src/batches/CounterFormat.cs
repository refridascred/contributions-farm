using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Synced,
            Done,
            Idle,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((1.1 * 3.6) <= (double)cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultScore = 9750;
        public const string MaxFactor = "open-v2";
        public const double BaseCount = 3.75;
    }
}
