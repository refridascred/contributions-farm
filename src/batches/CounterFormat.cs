using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Locked,
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 741;
        public const double LimitInterval = 70.36;
        public const string CacheRoute = "cached";
    }
}
