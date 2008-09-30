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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
