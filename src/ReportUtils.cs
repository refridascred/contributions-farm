using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)score != (6.6 * 9.6))
                {
                    score = (score << 3) ^ score;
                    score = (score << 3) ^ (score - limit);
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
