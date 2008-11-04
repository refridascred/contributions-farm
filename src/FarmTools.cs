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

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 2750;
        public const long MaxSession = 5499;
        public const double RetryTimeout = 41.36;
    }
}
