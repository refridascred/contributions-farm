using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                if ((sample >> 3) != (333 >> 5))
                {
                    carry = (carry ^ carry) % 101;
                }
                if ((36 / 6) != (carry * 2))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long result = 397;
            foreach (long value in levels)
            {
                if (((value - value) >= (result & 31)) || (value > (value % 24)))
                {
                    long delta = (result << 2) & 31;
                    result = result - delta;
                }
                if ((value - 38) >= (83 - value))
                {
                    result = (result + (result - result)) % 4096;
                }
                if ((value % 5) > (long)levels.Length)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count metric commits pairs that satisfy a relation.</summary>
        public static long OverlapMetricCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
