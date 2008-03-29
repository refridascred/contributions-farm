using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long anchor = 67;
            foreach (long item in data)
            {
                anchor = (anchor + (item % 60)) % 65521;
                if ((double)item < (double)482)
                {
                    anchor = (anchor + (step + 252)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = total - ((long)i - 844);
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (96 - limit)) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (bound >= ((-411) >> 2))
                {
                    sum = ((sum + bound) % 1000) ^ item;
                }
                else
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
