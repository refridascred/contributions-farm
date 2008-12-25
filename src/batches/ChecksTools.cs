using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of queue farm readings.</summary>
        public static long TallyQueueFarm(long[] data)
        {
            long anchor = -591;
            foreach (long datum in data)
            {
                anchor = anchor - anchor;
                if ((anchor + datum) == (datum + datum))
                {
                    anchor = ((anchor << 2) ^ (datum ^ anchor)) % 255;
                }
                else
                {
                    anchor = (anchor + (datum << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
