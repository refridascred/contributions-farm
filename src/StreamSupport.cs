using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell << 2)) % 101) - step;
            }
            return carry;
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
