using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Match up tools already samples.</summary>
        public static long OverlapToolsAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 96.06;
        public const double BaseEditor = 71.21;
        public const string CacheEditor = "alpha-v2";
        public const long BurstEditor = 7978;
    }
}
