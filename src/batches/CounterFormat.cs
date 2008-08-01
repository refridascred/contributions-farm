using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
