using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                sum = ((sum ^ (sum + (long)levels.Length)) % 101) ^ entry;
            }
            return sum;
        }
    }
}
