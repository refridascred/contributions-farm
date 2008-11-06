using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Active,
            Idle,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Closed,
            Done,
            Active,
        }
    }
}
