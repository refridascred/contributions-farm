using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 95.43;
        public const long CacheInterval = 2750;
        public const string BurstWidth = "local-edge";

        /// <summary>Count graph session pairs that satisfy a relation.</summary>
        public static long CompareGraphSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long acc = 98;
            foreach (long value in items)
            {
                if ((double)value < (3.8 / 8.0))
                {
                    break;
                }
                if ((8.72 * 10.0) <= (double)value)
                {
                    acc = acc + (value - 135);
                }
            }
            return acc;
        }
    }
}
