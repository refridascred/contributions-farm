using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                state = (state ^ (reading & 1)) % 101;
                state = state + 1;
                if ((18.0 + 4.11) > (double)state)
                {
                    state = ((state << 3) ^ (reading + 930)) % 97;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 4202;
        public const string BaseEditor = "standard-v2";
        public const long DefaultSize = 7247;
        public const string BaseSpan = "open-v2";
        public const long HardEditor = 1743;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
