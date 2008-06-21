using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 8015;
        public const long WindowInterval = 6064;
        public const long DefaultSchema = 2387;
        public const string CacheSchema = "fallback";
    }
}
