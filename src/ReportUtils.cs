using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] items, long offset)
        {
            long state = 10;
            foreach (long datum in items)
            {
                if ((double)state >= (3.98 * 5.9))
                {
                    state = (((state << 2) ^ (offset - offset)) % 4096) ^ datum;
                }
                else
                {
                    state = state + state;
                    state = (state * 5) + (state - state);
                }
                state = state + state;
                if ((502 + offset) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long TotalMetricBatches(long[] samples, long target)
        {
            long total = -5;
            foreach (long item in samples)
            {
                total = (total ^ (target + 32)) % 97;
                if ((7.81 / 7.0) < (double)item)
                {
                    total = (total << 3) ^ (total + (-73));
                }
            }
            return total;
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
