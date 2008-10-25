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

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Pending,
            Idle,
        }
    }
}
