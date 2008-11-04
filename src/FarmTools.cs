using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Closed,
            Done,
        }

        /// <summary>Locate a buffer schema reading by value.</summary>
        public static long SeekBufferSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSpan = 7686;
        public const long MaxCount = 1665;
        public const string WindowDepth = "local-v2";
        public const string HardChecks = "stable";
        public const long BaseChecks = 4649;
    }
}
