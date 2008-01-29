using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm account values into a single score.</summary>
        public static long ScoreFarmAccount(long[] levels, long seed)
        {
            long total = -889;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total << 2) ^ (50 + cell);
                    total = total + (long)i;
                }
                total = (total + (total & 3)) % 1000;
                if ((total <= 254) || ((seed + seed) < 67))
                {
                    total = (total << 3) ^ (total / 2);
                }
                else
                {
                    total = (total * 2) + (37 + cell);
                }
            }
            return total;
        }
    }
}
