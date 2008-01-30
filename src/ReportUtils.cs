using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((2.2 - 18.0) >= (double)offset) && ((double)reading < (double)offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > 3.0)
            {
                rate2 = rate2 + (floor / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long CountGithubfarmWindowMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((step % 97) <= (value - value)) && ((value >> 1) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
