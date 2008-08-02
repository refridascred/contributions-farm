using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "legacy-1";
        public const long IdleEditor = 8904;
        public const long LimitSpan = 4129;
        public const long WindowSpan = 139;
        public const long CacheEditor = 2517;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            New,
            Locked,
            Closed,
            Pending,
        }
    }
}
