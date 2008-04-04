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

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i > (6.6 - 7.0))
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
                else
                {
                    total = total ^ offset;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Retry,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long offset)
        {
            long slot = target ^ offset;
            if ((76 + offset) < (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((95 / 5) != (slot << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
