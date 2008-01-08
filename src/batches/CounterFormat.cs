using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3024;
        public const long RetryRatio = 3756;
        public const double StepReport = 85.02;
        public const string SoftWidth = "local-1";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
