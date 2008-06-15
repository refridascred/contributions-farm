using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= (hits * 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict-edge";
        public const long BurstCount = 9509;
        public const long DefaultContext = 9318;
        public const long MinCount = 6910;
        public const long LimitContext = 3657;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Dropped,
            Idle,
            Locked,
            Active,
        }
    }
}
