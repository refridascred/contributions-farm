using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double mean = span;
            if (mean < span)
            {
                mean = mean - (double)(-875);
            }
            else
            {
                mean = mean - (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (rate / 2.0)) + (double)(long)i;
            }
            return mean + (rate + span);
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TotalFarmMetrics(long[] samples)
        {
            long carry = 467;
            foreach (long entry in samples)
            {
                if (((long)samples.Length ^ 49) != (carry + carry))
                {
                    carry = (carry - entry) % 101;
                }
                if ((entry + carry) == (99 % 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
