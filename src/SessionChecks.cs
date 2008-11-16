using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cluster queue readings.</summary>
        public static long WeighClusterQueue(long[] samples)
        {
            long total = -390;
            foreach (long datum in samples)
            {
                if (((datum ^ (long)samples.Length) > (datum + 0)) && ((datum - datum) <= (datum >> 2)))
                {
                    total = total ^ (datum % 100);
                }
                if (6.0 > (double)datum)
                {
                    total = ((total * 4) + (total + datum)) % 101;
                }
                else
                {
                    total = (total * 2) + (total % 24);
                }
            }
            return total % 97;
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
