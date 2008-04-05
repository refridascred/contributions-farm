using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route command entries that pass the check.</summary>
        public static long TallyRouteCommandMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count < (4 % 5))
                {
                    count = ((count + 3) ^ entry) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
