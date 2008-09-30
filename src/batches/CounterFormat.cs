using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Closed,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Locate a layout context reading by value.</summary>
        public static long LookupLayoutContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
