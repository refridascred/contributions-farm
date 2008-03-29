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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 2710;
        public const long MaxCounter = 5581;
        public const long HardScore = 2063;
        public const double StepLevel = 8.33;
        public const long BatchCounter = 3762;

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

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 9726;
        public const double CacheBudget = 63.59;
        public const string RetryTimeout = "latest-v2";
        public const double CacheSpan = 88.77;
        public const long HardRatio = 9587;
    }
}
