using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Active,
            Failed,
            Ready,
            Done,
        }
    }
}
