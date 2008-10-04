using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Idle,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Find the first notes metrics entry that matches the target.</summary>
        public static long FindNotesMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long step, long target)
        {
            if ((target << 2) <= (step << 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (0.4 - 4.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (4 - bound)) % 1000;
                carry = ((carry * 4) + (carry << 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
