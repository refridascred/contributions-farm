using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit session token readings against a rule.</summary>
        public static long CountSessionTokenOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((floor & 7) == (matches + matches)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((592 ^ seen) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
