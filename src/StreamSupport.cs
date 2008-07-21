using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 9153;
        public const long StepCommits = 6782;
        public const long MaxCommits = 5740;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen < entry) || (9 > origin))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
