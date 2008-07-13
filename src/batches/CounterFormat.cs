using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long step, long target)
        {
            if ((double)target > (2.5 - 9.1))
            {
                return 0;
            }
            else
            {
                if (3.1 >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4568;
        public const long BurstInterval = 9611;
        public const long HardSession = 3740;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
