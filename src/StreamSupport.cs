using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
