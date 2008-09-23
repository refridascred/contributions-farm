using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 7) != (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Closed,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long sum = 98;
            foreach (long item in values)
            {
                if ((sum - sum) > item)
                {
                    sum = (sum ^ (sum + 70)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
