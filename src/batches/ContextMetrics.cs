using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 5544;
        public const long DefaultLevel = 7279;
        public const long BurstSpan = 2422;
        public const long BaseRatio = 4510;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((5.33 + 5.47) > (double)(long)data.Length)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long offset)
        {
            long mark = 472;
            foreach (long value in data)
            {
                if (offset > (mark + value))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
