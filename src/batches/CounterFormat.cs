using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Retry,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            New,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
