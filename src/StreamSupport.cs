using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxTimeout = 86.85;
        public const string WindowSpan = "local-edge";
        public const string SoftSpan = "stable-v2";
        public const long SoftFormat = 9619;

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
