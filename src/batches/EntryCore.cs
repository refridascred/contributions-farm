using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the window format series from a seed.</summary>
        public static long RollWindowFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = total + total;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseRatio = "staging-v2";
        public const long RetryMetrics = 1994;
        public const long MinMetrics = 2457;
        public const long RetrySize = 7524;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheDepth = 3787;
        public const long RetryCounter = 1818;
        public const long LimitCounter = 9275;
        public const long SoftCounter = 2381;
        public const long CacheCounter = 9145;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Pending,
            Idle,
        }
    }
}
