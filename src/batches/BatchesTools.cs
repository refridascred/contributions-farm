using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - result;
                result = (result * 5) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryRatio = 6817;
        public const long RetryReport = 4790;
        public const double LimitReport = 15.72;
        public const long IdleReport = 8824;
        public const double MaxSpan = 86.9;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Done,
            Pending,
            Active,
        }
    }
}
