using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up metrics account samples.</summary>
        public static long PairMetricsAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double rate, double floor)
        {
            double scale = rate * 2.8;
            if (scale < floor)
            {
                scale = scale + (rate + scale);
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (1.51 - floor);
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count / 4) >= 4)
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 924;
        public const long BurstWidth = 7743;
        public const long SoftMetric = 9451;
        public const string MaxMetric = "staging";
    }
}
