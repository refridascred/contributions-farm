using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Validate account metrics readings against a bound.</summary>
        public static bool VerifyAccountMetricsLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 85;
            foreach (long cell in values)
            {
                state = (((state << 3) ^ ((long)values.Length + state)) + cell) + seed;
            }
            return state % 1000;
        }
    }
}
