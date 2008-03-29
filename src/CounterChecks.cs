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

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Draft,
            Synced,
            Closed,
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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long limit)
        {
            long gap = target - limit;
            if ((limit % 60) < gap)
            {
                return 5;
            }
            else
            {
                if (!(gap <= (42 - target)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
