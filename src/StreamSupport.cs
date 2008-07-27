using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxCount = "legacy-v2";
        public const string WindowFilter = "latest";
        public const long MinDepth = 4937;
        public const long LimitFilter = 268;
        public const long IdleFilter = 711;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
