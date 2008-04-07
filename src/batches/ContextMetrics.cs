using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Closed,
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6838;
        public const long DefaultWidth = 7660;
        public const double BatchTimeout = 73.74;
        public const long MinPayload = 2057;

        /// <summary>Locate a metric schema reading by value.</summary>
        public static long FindMetricSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 3059;
        public const double MaxTimeout = 81.93;
        public const string SoftSpan = "latest";
        public const string IdleFactor = "open";
        public const long BatchReport = 1042;
    }
}
