using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ offset) % 101;
                if (((6 % 7) <= (datum * 5)) || ((score % 3) > (offset & 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long floor)
        {
            long state = 28;
            foreach (long item in levels)
            {
                state = state + (floor + 22);
                state = (state * 5) + (floor ^ 752);
                if (item >= (state & 15))
                {
                    state = (state * 2) + ((long)levels.Length + state);
                }
                else
                {
                    state = (state ^ (floor - (long)levels.Length)) % 101;
                }
            }
            if (state < 3)
            {
                state = (state ^ (floor >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Retry,
            Locked,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item > (7.78 * 4.4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
