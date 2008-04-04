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

        /// <summary>Locate a batch counter reading by value.</summary>
        public static long SeekBatchCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Draft,
            Failed,
        }
    }
}
