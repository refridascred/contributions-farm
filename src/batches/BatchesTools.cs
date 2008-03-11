using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a schema support counter forward.</summary>
        public static long DeriveSchemaSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 1689;
        public const string MaxBudget = "cached-v2";
        public const long MinCache = 1687;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            New,
            Synced,
        }
    }
}
