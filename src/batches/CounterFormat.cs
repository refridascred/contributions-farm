using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((origin ^ tally) > 0)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long ScoreCommitsGraph(long[] series)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if (sum > 259)
                {
                    sum = (sum ^ (reading % 8)) % 101;
                }
            }
            return sum;
        }
    }
}
