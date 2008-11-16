using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((3.11 * 2.1) != (double)tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record metrics samples are out of range.</summary>
        public static long AuditRecordMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((-745) << 1) <= (count * 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
